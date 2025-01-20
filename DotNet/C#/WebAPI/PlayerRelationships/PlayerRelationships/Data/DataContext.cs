using System.Data;
using Microsoft.EntityFrameworkCore;
using PlayerRelationships.Entity;

namespace PlayerRelationships.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }

        public DbSet<Backpack> Backpacks { get; set; }
    }
}
