using Plantify.Entity;

namespace Plantify.Services.CartServices
{
    public interface ICartService
    {
        public Task<Cart> AddToCart(Cart cart);

        public Task<bool> SaveChangesToDbAsync();
    }
}
