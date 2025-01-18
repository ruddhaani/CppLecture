using Microsoft.EntityFrameworkCore;
using Plantify.Data;
using Plantify.Entity;

namespace Plantify.Repositories.CartRepositories
{
    public class CartRepository : ICartRepository
    {
        private readonly DataContext _context;

        public CartRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Cart> AddToCart(Cart cart)
        {
            var existingCart = await _context.Cart.FirstOrDefaultAsync(x => x.ProductId == cart.ProductId);
            if ( existingCart != null)
            {
                existingCart.Quantity += cart.Quantity;
                _context.Entry(existingCart).State = EntityState.Modified;
            }
            else
            {
                _context.Cart.Add(cart);
            }

            return cart;
        }

        public async Task<Cart> UpdateQuantity(Cart cart)
        {
            var existingCart = await _context.Cart.FirstOrDefaultAsync(x => (x.ProductId == cart.ProductId) && (x.UserId == cart.UserId));
            existingCart.Quantity += cart.Quantity;
            if (existingCart.Quantity >= 1)
            {
                if (existingCart != null)
                {
                    _context.Entry(existingCart).State = EntityState.Modified;
                    return cart;
                }

            }
            else
            {
                _context.Cart.Remove(await _context.Cart.FirstOrDefaultAsync(x => (x.ProductId == cart.ProductId) && (x.UserId == cart.UserId)));
            }

            return null;
        }

        public async Task<IEnumerable<Cart>> GetCartItemsByUserIdAsync(int userId)
        {
            return await _context.Cart.Include(c => c.Product).Where(c => c.UserId == userId).ToListAsync();
        }

        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
