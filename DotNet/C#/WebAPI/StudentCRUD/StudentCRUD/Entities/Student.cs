using System.ComponentModel.DataAnnotations;
using StudentCRUD.DTOs;

namespace StudentCRUD.Entities
{
    public class Student
    {
        public Student()
        {
        }

        public Student(AddStudentDto addStudentDto)
        {
            Name = addStudentDto.Name;
            Email = addStudentDto.Email;
            Department = addStudentDto.Department;
        }

        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Department { get; set; }
    }
}
