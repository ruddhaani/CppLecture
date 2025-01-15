using Plantify.Entity;
using Plantify.Repositories.ProductRepositories;

namespace Plantify.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _productRepository.GetProducts();
        }

        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _productRepository.SaveChangesToDbAsync();
        }
    }
}
