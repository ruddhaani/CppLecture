using BasicCRUDPractice.Entity;

namespace BasicCRUDPractice.Services
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<Employee>> GetEmployees();

        public Employee AddEmployee(Employee employee);

        public void UpdateEmployee(Employee employee);

        public Task<Employee> GetEmployeeById(int id);


        public void DeleteEmployee(Employee employee);

        public Task<bool> SaveChangesToDbAsync();
    }
}
