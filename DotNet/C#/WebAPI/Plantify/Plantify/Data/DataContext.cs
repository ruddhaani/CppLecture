using Microsoft.EntityFrameworkCore;
using Plantify.Entity;

namespace Plantify.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserInformation> Users { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
