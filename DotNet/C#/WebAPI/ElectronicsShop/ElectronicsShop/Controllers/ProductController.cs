using AutoMapper;
using ElectronicsShop.Data;
using ElectronicsShop.DTOs.ProductDTOs;
using ElectronicsShop.Entities;
using ElectronicsShop.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElectronicsShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ProductController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductDto addProductDto)
        {

            var category = await _context.ProductCategories.FirstOrDefaultAsync(x => x.ProductCategoryId == addProductDto.ProductCategoryId);

            if (category == null)
            {
                return NotFound();
            }

            var product = _mapper.Map<Product>(addProductDto);

            _context.Products.Add(product);

            await _context.SaveChangesAsync();

            var productResponse = await _context.Products.Include(x => x.ProductCategory).FirstOrDefaultAsync(x => x.ProductId == product.ProductId);

            var mappedResponse = _mapper.Map<ProductResponse>(productResponse);

            return Ok(mappedResponse);
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _context.Products.Include(x => x.ProductCategory)
                                                  .Include(x => x.ProductImages)
                                                  .ToListAsync();

            var productResponses = _mapper.Map<List<ProductResponse>>(products);

            return Ok(productResponses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _context.Products.Include(x => x.ProductCategory).FirstOrDefaultAsync(x => x.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            var productResponse = _mapper.Map<ProductResponse>(product);

            return Ok(productResponse);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);

            await _context.SaveChangesAsync();

            return Ok("Deleted");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id , UpdateProductDto updateProductDto)
        {
            var product =  await _context.Products.FirstOrDefaultAsync(x => x.ProductId == id);

            if(product == null)
            {
                return NotFound();
            }

            _mapper.Map(updateProductDto, product);

            _context.Entry(product).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return Ok(_mapper.Map<ProductResponse>(product));

        }

    }
}
