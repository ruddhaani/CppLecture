using EMS.Dtos.EmployeeDtos;
using EMS.Entities;
using EMS.Repositories.EmployeeRepositories;
using EMS.Responses.EmployeeResponses;

namespace EMS.Services.EmployeeServices
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public Employee CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            Employee employee = new Employee(createEmployeeDto);
            return _employeeRepository.CreateEmployee(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            _employeeRepository.DeleteEmployee(employee);
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {

            return await _employeeRepository.GetEmployeeById(employeeId);
        }

        public async Task<IEnumerable<EmployeeResponse>> GetEmployees()
        {
            var employees = await _employeeRepository.GetEmployees();
            return employees.Select(employee => new EmployeeResponse(employee)).ToList();
        }

        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _employeeRepository.SaveChangesToDbAsync();
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.UpdateEmployee(employee);
        }
    }
}
