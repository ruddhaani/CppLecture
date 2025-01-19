using Plantify.Entity;

namespace Plantify.Services.ProductServices
{
    public interface IProductService
    {
        public Task<IEnumerable<Product>> GetProducts();

        public Task<Product> GetProductDetails(int productId);


        public Task<bool> SaveChangesToDbAsync();
    }
}
