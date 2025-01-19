using Microsoft.EntityFrameworkCore;
using Plantify.Data;
using Plantify.Entity;

namespace Plantify.Repositories.ProductRepositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProductDetails(int productId)
        {
            return await _context.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
