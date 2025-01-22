using AutoMapper;
using ElectronicsShop.Data;
using ElectronicsShop.DTOs.ProductDTOs;
using ElectronicsShop.DTOs.ProductImageDTOs;
using ElectronicsShop.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElectronicsShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ProductImageController(DataContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddProductImages(AddProductImageDto productImageDto)
        {
            var productExists = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == productImageDto.ProductId);

            if (productExists == null)
            {
                return NotFound();
            }

            var productImage = _mapper.Map<ProductImage>(productImageDto);

            _context.ProductImages.Add(productImage);

            await _context.SaveChangesAsync();

            return Ok("added image");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductImage(int id)
        {
            var productImage = await _context.ProductImages.FindAsync(id);

            if(productImage == null)
            {
                return NotFound();
            }

            _context.ProductImages.Remove(productImage);

            await _context.SaveChangesAsync();

            return Ok("deleted!");
 
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductImage(int id , UpdateProductImageDto updateProductImageDto)
        {
            var productImage = await _context.ProductImages.FindAsync(id);

            if(productImage == null)
            {
                return NotFound();  
            }

            _mapper.Map(updateProductImageDto, productImage);

            await _context.SaveChangesAsync();

            return Ok("updated");
        }

    }
}
