using EMS.Dtos.EmployeeDtos;
using EMS.Entities;
using EMS.Responses.EmployeeResponses;

namespace EMS.Services.EmployeeServices
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeResponse>> GetEmployees();

        Task<Employee> GetEmployeeById(int employeeId);

        Employee CreateEmployee(CreateEmployeeDto employee);

        void UpdateEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        Task<bool> SaveChangesToDbAsync();
    }
}
