using BasicCRUDPractice.Entity;

namespace BasicCRUDPractice.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetEmployees();

        public Employee AddEmployee(Employee employee);

        public Task<Employee> GetEmployeeById(int id);

        public void UpdateEmployee(Employee employee);

        public void DeleteEmployee(Employee employee);

        public Task<bool> SaveChangesToDbAsync();
    }
}
