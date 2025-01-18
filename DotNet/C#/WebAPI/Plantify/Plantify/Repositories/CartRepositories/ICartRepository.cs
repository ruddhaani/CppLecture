using Plantify.Entity;

namespace Plantify.Repositories.CartRepositories
{
    public interface ICartRepository
    {
        public Task<Cart> AddToCart(Cart cart);

        public Task<IEnumerable<Cart>> GetCartItemsByUserIdAsync(int userId);

        public Task<Cart> UpdateQuantity(Cart cart);
        public Task<bool> SaveChangesToDbAsync();


    }
}
