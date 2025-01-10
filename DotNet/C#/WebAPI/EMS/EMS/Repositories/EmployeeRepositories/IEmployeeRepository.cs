using EMS.Entities;

namespace EMS.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();

        Task<Employee> GetEmployeeById(int employeeId);

        Employee CreateEmployee(Employee employee);

        void UpdateEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        Task<bool> SaveChangesToDbAsync();
    }
}
