using EMS.Data;
using EMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace EMS.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _dataContext;

        public EmployeeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Employee CreateEmployee(Employee employee)
        {
            _dataContext.Employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            _dataContext.Employees.Remove(employee);
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await _dataContext.Employees.FirstOrDefaultAsync(x=> x.EmployeeId == employeeId);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _dataContext.Employees.ToListAsync();
        }

        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _dataContext.SaveChangesAsync() > 0;
        }

        public void UpdateEmployee(Employee employee)
        {
            _dataContext.Entry(employee).State = EntityState.Modified;
        }
    }
}
