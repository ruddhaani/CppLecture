using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plantify.Params;
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

        [HttpGet("productDetails")]
        public async Task<ActionResult<ProductResponse>> GetProductDetails(string productId)
        {
            var product = await _productService.GetProductDetails(Convert.ToInt32(productId));

            ProductResponse productResponse = new ProductResponse(product);

            if(productResponse != null)
            {
                return Ok(productResponse);
            }

            return BadRequest();
        } 

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponse>>> GetProducts([FromQuery] ProductParams productParams)
        {
            var products = await _productService.GetProducts();

            if (!string.IsNullOrEmpty(productParams.SearchText))
            {
                products = products.Where(x =>
                                    x.ProductName
                                    .Contains(productParams.SearchText, StringComparison.OrdinalIgnoreCase));
            }

            int totalCount = products.Count();
            int totalPages = (int)Math.Ceiling(totalCount / (double)productParams.PageSize);

            int skipElements = (productParams.PageNumber - 1) * productParams.PageSize;
            products = products.Skip(skipElements).Take(productParams.PageSize);

            Response.Headers.Add("X-PageNumber", productParams.PageNumber.ToString());
            Response.Headers.Add("X-PageSize", productParams.PageSize.ToString());
            Response.Headers.Add("X-TotalPages", totalPages.ToString());

            return products.Select(x => new ProductResponse(x)).ToList();
        }
    }
}
