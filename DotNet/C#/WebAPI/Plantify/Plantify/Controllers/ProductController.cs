using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plantify.Responses.ProductResponses;
using Plantify.Services.ProductServices;

namespace Plantify.Controllers
{
    public class ProductController : BaseAPIController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponse>>> GetProducts()
        {
            var products = await _productService.GetProducts();

            return products.Select(x => new ProductResponse(x)).ToList();
        }
    }
}
