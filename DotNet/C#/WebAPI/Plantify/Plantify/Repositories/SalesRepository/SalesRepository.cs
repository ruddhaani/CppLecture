using Microsoft.EntityFrameworkCore;
using Plantify.Data;
using Plantify.Entity;

namespace Plantify.Repositories.SalesRepository
{
    public class SalesRepository : ISalesRepository
    {
        private readonly DataContext _context;

        public SalesRepository(DataContext context)
        {
            _context = context;
        }
        public async void AddToSales(IEnumerable<Cart> cartItems)
        {
            foreach(var cartItem in cartItems)
            {
                _context.Sales.Add(new Sales(cartItem));
                _context.Cart.Remove(cartItem);
            }

        }

        public async Task<IEnumerable<Sales>> GetHistory(int id)
        {
            return await _context.Sales.Include(c => c.Product).Where(c => c.UserId == id).ToListAsync();
        }

        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
