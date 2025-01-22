using AutoMapper;
using ElectronicsShop.Data;
using ElectronicsShop.DTOs;
using ElectronicsShop.DTOs.CartDTOs;
using ElectronicsShop.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElectronicsShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CartController(DataContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> CreateCart(int id)
        {
            var user = await _context.Users.Include(x => x.Cart).FirstOrDefaultAsync(x => x.UserId == id);

            if(user == null)
            {
                return NotFound();
            }

            if(user.Cart != null)
            {
                return BadRequest();
            }

            var cart = new Entities.Cart { UserId = user.UserId };
            _context.Carts.Add(cart);

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("{cartId}/item")]
        public async Task<IActionResult> AddCartItems(int cartId , AddCartItemDto addCartItemDto)
        {
            var cart = await _context.Carts.Include(c => c.CartItems).FirstOrDefaultAsync(x => x.CartId == cartId);

            if(cart == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(ci => ci.ProductId == addCartItemDto.ProductId);

            if(product == null)
            {
                return NotFound();
            }

            var existingItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == addCartItemDto.ProductId);

            if(existingItem != null)
            {
                existingItem.Quantity += addCartItemDto.Quantity;
                existingItem.Price = existingItem.Quantity * product.ProductPrice;
            }
            else
            {
                var cartItem = new CartItem
                {
                    CartId = cartId,
                    ProductId = addCartItemDto.ProductId,
                    Quantity = addCartItemDto.Quantity,
                    Price = addCartItemDto.Quantity * product.ProductPrice
                };

                _context.CartItems.Add(cartItem);
            }

            await _context.SaveChangesAsync();

            return Ok("Items added to cart");


        }

        [HttpGet("{cartId}")]
        public async Task<IActionResult> GetCart(int cartId)
        {
            var cart = await _context.Carts.Include(c => c.CartItems)
                                           .ThenInclude(pi => pi.Product)
                                           .FirstOrDefaultAsync(x => x.CartId == cartId);

            if(cart == null)
            {
                return NotFound();
            }

            var cartResponse = _mapper.Map<CartResponse>(cart);
            return Ok(cartResponse);
        }
    }
}
