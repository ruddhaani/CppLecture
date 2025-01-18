using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plantify.Dtos.CartDtos;
using Plantify.Entity;
using Plantify.Services.CartServices;
using Plantify.Services.JWT;

namespace Plantify.Controllers
{
    public class CartController : BaseAPIController
    {
        private readonly JwtService _jwtService;
        private readonly ICartService _cartService;

        public CartController (JwtService jwtService , ICartService cartService)
        {
            _jwtService = jwtService;
            _cartService = cartService;
        }

        [Authorize]
        [HttpGet("cart")]
        public async Task<IActionResult> GetCartItemsByUserId()
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
                var claimsPrincipal = _jwtService.ValidateToken(token);

                var id = claimsPrincipal.FindFirst("UserId")?.Value;

                if (string.IsNullOrEmpty(id))
                {
                    return Unauthorized("Please login or sign up");
                }

                var cartItems = await _cartService.GetCartItemsByUserIdAsync(Convert.ToInt32(id));

                var result = cartItems.Select(c => new
                {
                    c.CartId,
                    c.Quantity,
                    Product = new
                    {
                        c.Product.ProductId,
                        c.Product.ProductName,
                        c.Product.ProductDescription,
                        c.Product.Price,
                        c.Product.ProductImageUrl
                    }
                });

                return Ok(result);
            }
            catch(Exception ex)
            {
                return Unauthorized("Please log in or sign up");
            }
        }

        [Authorize]
        [HttpPut("updateQuantity")]
        public async Task<ActionResult<Cart>> UpdateQuantity(UpdateQuantityDto updateQuantityDto)
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

                var claimsPrincipal = _jwtService.ValidateToken(token);

                var id = claimsPrincipal.FindFirst("UserId")?.Value;

                if (string.IsNullOrEmpty(id))
                {
                    return Unauthorized("Please log in or sign up!");
                }

                var cart = new Cart(updateQuantityDto);

                cart.UserId = Convert.ToInt32(id);

                Cart newItem = await _cartService.UpdateQuantity(cart);

                if(await _cartService.SaveChangesToDbAsync())
                {
                    return Ok(newItem);
                }

                return BadRequest();


            }catch(Exception ex)
            {
                return Unauthorized();
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Cart>> AddToCart([FromQuery]int productId)
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

                var claimsPrincipal = _jwtService.ValidateToken(token);

                var id = claimsPrincipal.FindFirst("UserId")?.Value;

                if (string.IsNullOrEmpty(id))
                {
                    return Unauthorized("Please login or sign up");
                }

                AddToCartDto addToCartDto = new AddToCartDto()
                {
                    ProductId = productId,
                    UserId = Convert.ToInt32(id),
                    Quantity = 1,
                };

                Cart newCartItem = await _cartService.AddToCart(new Cart(addToCartDto));

                if (await _cartService.SaveChangesToDbAsync())
                {
                    return Ok(newCartItem);
                }

                return BadRequest("Some issue occured");


            }
            catch (Exception ex)
            {
                return Unauthorized($"Please sign up or log in ${ex.Message}");
            }

        }
    }
}
