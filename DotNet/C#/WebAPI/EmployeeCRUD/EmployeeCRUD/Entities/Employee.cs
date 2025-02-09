using System.ComponentModel.DataAnnotations;
using EmployeeCRUD.DTOs.EmployeeDTOs;

namespace EmployeeCRUD.Entities
{
    public class Employee
    {

        public Employee()
        {

        }

        public Employee(CreateEmployeeDTO createEmployeeDTO)
        {
            Name = createEmployeeDTO.Name;
            Email = createEmployeeDTO.Email;
            Salary = createEmployeeDTO.Salary;
        }
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public double Salary { get; set; }
    }
}
