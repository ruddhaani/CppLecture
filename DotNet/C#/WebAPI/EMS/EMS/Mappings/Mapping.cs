using EMS.Dtos.EmployeeDtos;
using EMS.Entities;

namespace EMS.Mappings
{
    public static class Mapping
    {
        public static void MapUpdateEmployeeDtoWithEmployee(this Employee employee,UpdateEmployeeDto updateEmployeeDto)
        {
            employee.Name = updateEmployeeDto.Name;
            employee.Email = updateEmployeeDto.Email;
            employee.Salary = updateEmployeeDto.Salary;
        }
    }
}
