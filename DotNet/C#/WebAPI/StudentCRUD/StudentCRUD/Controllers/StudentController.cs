using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentCRUD.DTOs;
using StudentCRUD.Entities;
using StudentCRUD.Params;
using StudentCRUD.Services;

namespace StudentCRUD.Controllers
{
    public class StudentController : BaseAPIController
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(AddStudentDto addStudentDto)
        {
            Student student = new Student(addStudentDto);

            _studentService.AddStudent(student);

            if(await _studentService.SaveChangesToDbAsync())
            {
                return Ok(addStudentDto);
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents([FromQuery] StudentParams parameters)
        {

            var students = await _studentService.GetStudents();

            Response.Headers.Add("X-Total-Count", students.Count().ToString());

            int skipElements = (parameters.PageNumber - 1) * parameters.PageSize;

            int takeElements = Math.Min(students.Count() - skipElements, parameters.PageSize);

            if (!string.IsNullOrEmpty(parameters.SearchText))
            {
                students = students.Where(x => x.Name.Contains(parameters.SearchText, StringComparison.OrdinalIgnoreCase));
            }

            int totalPages = students.Count() / parameters.PageSize;

            if(students.Count() % parameters.PageSize != 0)
            {
                totalPages++;
            }

            students = students.Skip(skipElements).Take(takeElements).ToList();

            Response.Headers.Add("X-Total-Pages", totalPages.ToString());


            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = await _studentService.GetStudentById(id);

            if(student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _studentService.GetStudentById(id);

            if(student == null)
            {
                return NotFound();
            }

            _studentService.DeleteStudent(student);

            if (await _studentService.SaveChangesToDbAsync())
            {
                return Ok();
            }

            return BadRequest();

        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudent(UpdateStudentDto updateStudentDto)
        {
            var student = await _studentService.GetStudentById(updateStudentDto.StudentId);

            if(student == null)
            {
                return NotFound();
            }

            student.Name = updateStudentDto.Name;
            student.Email = updateStudentDto.Email;
            student.Department = updateStudentDto.Department;

            _studentService.UpdateStudent(student);

            if(await _studentService.SaveChangesToDbAsync())
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
