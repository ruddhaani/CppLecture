using Microsoft.AspNetCore.Mvc;
using Plantify.Entity;

namespace Plantify.Services.SalesServices
{
    public interface ISalesService
    {
        public void AddToSales(IEnumerable<Cart> cartItems);

        public Task<bool> SaveChangesToDbAsync();

        public Task<IEnumerable<Sales>> GetHistory(int id);

    }
}
