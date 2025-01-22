using Microsoft.EntityFrameworkCore;
using StudentCRUD.Entities;

namespace StudentCRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
