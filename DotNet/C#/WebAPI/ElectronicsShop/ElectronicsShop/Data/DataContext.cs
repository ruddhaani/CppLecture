using ElectronicsShop.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElectronicsShop.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<ProductCategory> ProductCategories{ get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(c => c.Cart)
                .WithOne(c => c.User)
                .HasForeignKey<Cart>(c => c.UserId);

            modelBuilder.Entity<User>()
                .HasMany(c => c.Orders)
                .WithOne(c => c.User)
                .HasForeignKey(o => o.UserId);

            modelBuilder.Entity<ProductCategory>()
                .HasMany(c => c.Products)
                .WithOne(u => u.ProductCategory)
                .HasForeignKey(c => c.ProductCategoryId);

            modelBuilder.Entity<Cart>()
                .HasMany(c => c.CartItems)
                .WithOne(c => c.Cart)
                .HasForeignKey(u => u.CartId);

            modelBuilder.Entity<CartItem>()
                .HasOne(c => c.Product)
                .WithMany()
                .HasForeignKey(ci => ci.ProductId);

            modelBuilder.Entity<Order>()
                .HasMany(oi => oi.OrderItems)
                .WithOne(c => c.Order)
                .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(p => p.Product)
                .WithMany()
                .HasForeignKey(p => p.ProductId);

            modelBuilder.Entity<User>()
               .Property(u => u.Email)
               .IsRequired();

            modelBuilder.Entity<ProductImage>()
                .HasOne(p => p.Product)
                .WithMany(pi => pi.ProductImages)
                .HasForeignKey(p => p.ProductId);
        }

    }
}
