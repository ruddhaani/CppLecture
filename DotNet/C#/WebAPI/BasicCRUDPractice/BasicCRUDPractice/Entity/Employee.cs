using System.ComponentModel.DataAnnotations;
using BasicCRUDPractice.DTOs;

namespace BasicCRUDPractice.Entity
{
    public class Employee
    {

        public Employee()
        {

        }

        public Employee(CreateEmployeeDto employeeDto)
        {
            Name = employeeDto.Name;
            Department = employeeDto.Department;
            Salary = employeeDto.Salary;
        }

        [Key]
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public double Salary { get; set; }
    }
}
