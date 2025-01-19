using Plantify.Entity;

namespace Plantify.Repositories.ProductRepositories
{
    public interface IProductRepository
    {
        public Task<IEnumerable<Product>> GetProducts();

        public Task<Product> GetProductDetails(int productId);

        public Task<bool> SaveChangesToDbAsync();
    }
}
