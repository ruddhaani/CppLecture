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

        public DbSet<Cart> Cart { get; set; }

        public DbSet<Sales> Sales { get; set; }


        //protected internal virtual void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Cart>()
        //        .HasMany(x => x.Products)
        //        .WithOne(x => x.Cart)
        //        .HasForeignKey(x => x.CartId)
        //        .OnDelete(DeleteBehavior.Cascade);



        //}


    }
}
