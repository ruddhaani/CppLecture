using Microsoft.EntityFrameworkCore;
using ProductUserRelationship.Entity;

namespace ProductUserRelationship.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
