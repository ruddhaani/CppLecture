using AutoMapper;
using ElectronicsShop.Data;
using ElectronicsShop.DTOs.CategoryDTOs;
using ElectronicsShop.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElectronicsShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;


        public ProductCategoryController(DataContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            return Ok(await _context.ProductCategories.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var category = await _context.ProductCategories.FindAsync(id);

            if(category == null)
            {
                return NotFound();
            }

            return Ok(category.Category);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(AddCategoryDto addCategoryDto)
        {

            if (string.IsNullOrEmpty(addCategoryDto.Category))
            {
                return BadRequest("Category name is required.");
            }

            var category = _mapper.Map<ProductCategory>(addCategoryDto);

            _context.ProductCategories.Add(category);

            await _context.SaveChangesAsync();

            return Ok(category);
        }
    }
}
