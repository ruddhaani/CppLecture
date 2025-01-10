using System.ComponentModel.DataAnnotations;
using EMS.Dtos.EmployeeDtos;

namespace EMS.Entities
{
    public class Employee
    {
        public Employee()
        {

        }

        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        public Employee(CreateEmployeeDto createEmployeeDto)
        {
            Name = createEmployeeDto.Name;
            Email = createEmployeeDto.Email;
            Salary = createEmployeeDto.Salary;
        }

        [Key]
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public double Salary { get; set; }

    }
}
