using EmployeeJWTTokenPractice.Entity;
using Microsoft.EntityFrameworkCore;

namespace EmployeeJWTTokenPractice.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
