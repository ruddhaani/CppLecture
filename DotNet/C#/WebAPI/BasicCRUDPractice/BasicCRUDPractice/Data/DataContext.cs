using BasicCRUDPractice.Entity;
using Microsoft.EntityFrameworkCore;

namespace BasicCRUDPractice.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
