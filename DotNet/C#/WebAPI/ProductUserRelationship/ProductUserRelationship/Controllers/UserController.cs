using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductUserRelationship.Data;
using ProductUserRelationship.DTOs;
using ProductUserRelationship.Entity;

namespace ProductUserRelationship.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCartItems(int id)
        {
            // Retrieve the user along with their cart and products
            var user = await _context.Users
                            .Include(c => c.Cart)
                            .ThenInclude(c => c.Products)
                            .FirstOrDefaultAsync(x => x.UserId == id);

            // Check if user exists
            if (user == null)
            {
                return NotFound(new { Message = "User not found" });
            }

            // Map the data to a DTO
            var userDto = new
            {
                UserId = user.UserId,
                UserName = user.Name,
                Cart = user.Cart == null ? null : new
                {
                    CartId = user.Cart.CartId,
                    Products = user.Cart.Products.Select(p => new
                    {
                        ProductId = p.ProductId,
                        ProductName = p.Name,
                        Price = p.Price,
                    }).ToList()
                }
            };

            // Return the DTO as the response
            return Ok(userDto);
        }


        [HttpPost("addtocart")]
        public async Task<ActionResult<User>> AddtoCart(AddToCartDto request)
        {

            var existingProduct = await _context.Products.FirstOrDefaultAsync(z => z.ProductId == request.ProductId);

            if(existingProduct == null)
            {
                return NotFound($"Product with ID {request.ProductId} does not exist.");
            }

            var user = await _context.Users
                                        .Include(c => c.Cart)
                                        .ThenInclude(c => c.Products)
                                        .FirstOrDefaultAsync(x => x.UserId == request.UserId);

            if(user == null)
            {
                return NotFound($"User with ID {request.UserId} does not exist.");
            }

            if(user.Cart == null)
            {
                user.Cart = new Cart
                {
                    User = user,
                    Products = new List<Products> { existingProduct }
                };
            }
            else
            {
                if (user.Cart.Products.Any(p => p.ProductId == existingProduct.ProductId))
                {
                    return BadRequest("Product is already in the cart.");
                }

                user.Cart.Products.Add(existingProduct);
            }

            await _context.SaveChangesAsync();

            return Ok(user);


        }

        [HttpPost]
        public async Task<ActionResult<User>> Signup(UserCreateDto request)
        {
            var user = new User
            {
                Name = request.Name,
                Email = request.Email,
                Phone = request.Phone,
                Password = request.Password
            };

            _context.Add(user); 

            await _context.SaveChangesAsync();

            return Ok(user);
        }
    }
}
