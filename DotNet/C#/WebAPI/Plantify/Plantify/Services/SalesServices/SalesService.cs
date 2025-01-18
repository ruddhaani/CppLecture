using Plantify.Entity;
using Plantify.Repositories.SalesRepository;

namespace Plantify.Services.SalesServices
{
    public class SalesService : ISalesService
    {
        private readonly ISalesRepository _salesRepository;

        public SalesService(ISalesRepository salesRepository)
        {
            _salesRepository = salesRepository;
        }
        public void AddToSales(IEnumerable<Cart> cartItems)
        {
            _salesRepository.AddToSales(cartItems);
        }

        public async Task<IEnumerable<Sales>> GetHistory(int id)
        {
            return await _salesRepository.GetHistory(id);
        }


        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _salesRepository.SaveChangesToDbAsync();
        }
    }
}
