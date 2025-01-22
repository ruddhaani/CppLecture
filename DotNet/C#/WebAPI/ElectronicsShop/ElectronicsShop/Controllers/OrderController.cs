using AutoMapper;
using ElectronicsShop.Data;
using ElectronicsShop.DTOs.OrderDTOs;
using ElectronicsShop.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElectronicsShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public OrderController(DataContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> CreateOrder(int id , AddOrderDto addOrderDto)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserId == id);

            if(user == null)
            {
                return NotFound();
            }

            var order = new Order
            {
                UserId = id,
                OrderItems = new List<OrderItem>()
            };

            foreach (var itemDto in addOrderDto.OrderItems)
            {
                var product = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == itemDto.ProductId);

                if(product == null)
                {
                    return NotFound();
                }

                var orderItem = new OrderItem
                {
                    ProductId = itemDto.ProductId,
                    Order = order
                };

                order.OrderItems.Add(orderItem);
            }

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            var orderResponse = _mapper.Map<OrderResponseDto>(order);
            return Ok(orderResponse);
        }

        [HttpGet("user/{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var orders = await _context.Orders
                                       .Include(o => o.OrderItems)
                                       .ThenInclude(pi => pi.Product)
                                       .Where(o => o.UserId == id)
                                       .ToListAsync();

            if (!orders.Any())
            {
                return NotFound();
            }
            return Ok(orders);
        }
    }
}
