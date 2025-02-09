using EmployeeCRUD.DTOs.EmployeeDTOs;
using EmployeeCRUD.Entities;

namespace EmployeeCRUD.Mappings
{
    public static class EmployeeMappings
    {
        public static void MapUpdateEmployeeDTOWithEmployee(this Employee employee , UpdateEmployeeDTO updateEmployeeDto)
        {
            employee.Name = updateEmployeeDto.Name;
            employee.Salary = updateEmployeeDto.Salary;
            employee.Email = updateEmployeeDto.Email;
        }
    }
}
