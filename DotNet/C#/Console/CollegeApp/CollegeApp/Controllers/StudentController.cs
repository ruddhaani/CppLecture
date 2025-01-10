using CollegeApp.Controllers.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("All", Name = "GetAllStudents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]


        public ActionResult<IEnumerable<StudentDTO>> GetStudents()
        {

            //var students = new List<StudentDTO>();

            // foreach(var item in CollegeRepository.students)
            //{
            //    //create object for studentDTO
            //    StudentDTO obj = new StudentDTO()
            //    {
            //        Id = item.Id,
            //        StudentName = item.StudentName,
            //        Address = item.Address,
            //        Email = item.Email
            //    };
            //    students.Add(obj);
            //}

            //using linq 
            var students = CollegeRepository.students.Select(s => new StudentDTO()
            {
                Id = s.Id,
                StudentName = s.StudentName,
                Address = s.Address,
                Email = s.Email
            });
            return Ok(students);

            //ok --- 200 ---success
            return Ok(CollegeRepository.students);

        }

        //-----------------------------------------------------------------------------------------------------


        //[HttpGet("{id:int}")]
        //public Student GetStudentById(int id)
        //{
        //    return CollegeRepository.students.Where(n => n.Id == id).FirstOrDefault();
        //}

        //----------------------------------------------------------------------------------------------------
        [HttpGet]
        [Route("{id:int}", Name = "GetStudentById")]
        //to document responses use 'produce' attribute
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public ActionResult<StudentDTO> GetStudentById(int id)
        {
            //badrequest for 400 client error 
            if (id <= 0)
                return BadRequest();
            var student = CollegeRepository.students.Where(n => n.Id == id).FirstOrDefault();
            //not found 404 client error
            if (student == null)
                return NotFound($"the student with id {id} not found");

            var StudentDTo = new StudentDTO
            {
                Id = student.Id,
                StudentName = student.StudentName,
                Address = student.Address,
                Email = student.Email
            };

            return Ok(StudentDTo);
        }

        //-------------------------------------------------------------------------------------------------------

        [HttpGet]
        [Route("{name:alpha}", Name = "GetStudentsByName")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<StudentDTO> GetStudentByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return BadRequest("Name cannot be empty");

            var student = CollegeRepository.students.Where(n => n.StudentName == name).FirstOrDefault();
            // Not found 404 client error
            if (student == null)
                return NotFound($"The student with name {name} not found");

            var StudentDTo = new StudentDTO
            {
                Id = student.Id,
                StudentName = student.StudentName,
                Address = student.Address,
                Email = student.Email
            };

            return Ok(StudentDTo);

        }
        //--------------------------------------------------------------------------------------------------------------------------------

        [HttpPost]
        [Route("Create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<StudentDTO> CreateStudent([FromBody] StudentDTO model)
        {

            //if(!ModelState.IsValid)
            //    return BadRequest(ModelState);

            if (model == null)
                return BadRequest();

            //directly adding error message to model state
            //if(model.AdmissionDate<DateTime.Now)
            //{
            //    ModelState.AddModelError("Admission Error", "Admission must be greater than or equal to todays data");

            //    return BadRequest(ModelState);
            //}
            int newId = CollegeRepository.students.LastOrDefault().Id + 1;
            Student student = new Student
            {
                Id = newId,
                StudentName = model.StudentName,
                Address = model.Address,
                Email = model.Email

            };
            CollegeRepository.students.Add(student);
            model.Id = student.Id;
            return CreatedAtRoute("GetStudentById", new {id=model.Id}, model);

            //return Ok(model);

        }

  //-------------------------------------------------------------------------------------------------------

        [HttpDelete("{id}", Name = "DeleteStudentById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<bool> DeleteStudent(int id)
        {
            //badrequest for 400 client error 
            if (id <= 0)
                return BadRequest();
            var student = CollegeRepository.students.Where(n => n.Id == id).FirstOrDefault();
            //not found 404 client error
            if (student == null)
                return NotFound($"the student with id {id} not found");
            //var student = CollegeRepository.students.Where(n => n.Id == id).FirstOrDefault();
            CollegeRepository.students.Remove(student);

            return Ok(true);

        }

    }
}