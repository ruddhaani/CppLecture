using Plantify.Entity;
using Plantify.Repositories.CartRepositories;

namespace Plantify.Services.CartServices
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
        public async Task<Cart> AddToCart(Cart cart)
        {
            return await _cartRepository.AddToCart(cart);
        }

        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _cartRepository.SaveChangesToDbAsync();
        }
    }
}
