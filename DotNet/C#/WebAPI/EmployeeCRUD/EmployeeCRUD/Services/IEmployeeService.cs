using EmployeeCRUD.Entities;

namespace EmployeeCRUD.Services
{
    public interface IEmployeeService
    {
        public Employee Create(Employee employee);

        public void Update(Employee employee);

        public void Delete(Employee employee);

        public Task<IEnumerable<Employee>> GetEmployees();

        public Task<Employee> GetEmployeeById(int id);

        public Task<bool> SaveChangesToDbAsync();
    }
}
