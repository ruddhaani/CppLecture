using EmployeeCRUD.Entities;
using EmployeeCRUD.Repository;

namespace EmployeeCRUD.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee Create(Employee employee)
        {
            return _employeeRepository.Create(employee);
        }

        public void Delete(Employee employee)
        {
            _employeeRepository.Delete(employee);
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _employeeRepository.GetEmployeeById(id);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _employeeRepository.GetEmployees();
        }

        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _employeeRepository.SaveChangesToDbAsync();
        }

        public void Update(Employee employee)
        {
            _employeeRepository.Update(employee);
        }
    }
}
