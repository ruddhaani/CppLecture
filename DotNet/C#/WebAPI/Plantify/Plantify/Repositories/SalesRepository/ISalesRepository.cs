using Plantify.Entity;

namespace Plantify.Repositories.SalesRepository
{
    public interface ISalesRepository
    {
        public void AddToSales(IEnumerable<Cart> cartItems);

        public Task<bool> SaveChangesToDbAsync();

        public Task<IEnumerable<Sales>> GetHistory(int id);
    }
}
