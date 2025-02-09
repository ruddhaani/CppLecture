using EmployeeCRUD.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
