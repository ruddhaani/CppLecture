using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plantify.Entity;
using Plantify.Services.CartServices;
using Plantify.Services.JWT;
using Plantify.Services.SalesServices;

namespace Plantify.Controllers
{
    
    public class SalesController : BaseAPIController
    {
        private readonly JwtService _jwtService;
        private readonly ISalesService _salesService;
        private readonly ICartService _cartService;

        public SalesController(JwtService jwtService , ISalesService salesService , ICartService cartService)
        {
            _jwtService = jwtService;
            _salesService = salesService;
            _cartService = cartService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sales>>> GetHistory()
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

                var claimsPrincipal = _jwtService.ValidateToken(token);

                var id = claimsPrincipal.FindFirst("UserId")?.Value;

                if (string.IsNullOrEmpty(id))
                {
                    return Unauthorized();
                }

                var historyItems = await _salesService.GetHistory(Convert.ToInt32(id));

                var result = historyItems.Select(c => new
                {
                    c.SalesId,
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
                return Unauthorized();
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddToSales()
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

                var claimsPrincipal = _jwtService.ValidateToken(token);

                var id = claimsPrincipal.FindFirst("UserId")?.Value;

                if (string.IsNullOrEmpty(id))
                {
                    return Unauthorized();
                }

                var cartItems = await _cartService.GetCartItemsByUserIdAsync(Convert.ToInt32(id));

                _salesService.AddToSales(cartItems);

                if (await _salesService.SaveChangesToDbAsync())
                {
                    return Ok();
                }

                return BadRequest();
            }catch (Exception ex)
            {
                return Unauthorized();
            }
        }
    }
}
