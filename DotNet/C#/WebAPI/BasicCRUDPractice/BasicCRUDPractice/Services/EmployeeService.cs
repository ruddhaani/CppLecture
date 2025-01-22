using BasicCRUDPractice.Entity;
using BasicCRUDPractice.Repositories;

namespace BasicCRUDPractice.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _repository.GetEmployeeById(id);
        }


        public Employee AddEmployee(Employee employee)
        {
            return _repository.AddEmployee(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            _repository.DeleteEmployee(employee);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _repository.GetEmployees();
        }

        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _repository.SaveChangesToDbAsync();
        }

        public void UpdateEmployee(Employee employee)
        {
            _repository.UpdateEmployee(employee);
        }
    }
}
