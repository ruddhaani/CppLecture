using BasicCRUDPractice.Data;
using BasicCRUDPractice.Entity;
using Microsoft.EntityFrameworkCore;

namespace BasicCRUDPractice.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;

        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
        }
    }
}
