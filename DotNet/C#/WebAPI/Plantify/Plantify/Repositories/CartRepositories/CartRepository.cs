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

        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
