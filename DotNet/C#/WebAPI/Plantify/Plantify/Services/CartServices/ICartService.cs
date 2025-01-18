using Plantify.Entity;

namespace Plantify.Services.CartServices
{
    public interface ICartService
    {
        public Task<Cart> AddToCart(Cart cart);

        public Task<Cart> UpdateQuantity(Cart cart);

        public Task<IEnumerable<Cart>> GetCartItemsByUserIdAsync(int userId);
        public Task<bool> SaveChangesToDbAsync();

    }
}
