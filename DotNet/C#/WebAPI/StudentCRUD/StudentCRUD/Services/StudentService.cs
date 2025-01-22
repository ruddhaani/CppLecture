using StudentCRUD.Entities;
using StudentCRUD.Repositories;

namespace StudentCRUD.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Student AddStudent(Student student)
        {
            return _studentRepository.AddStudent(student);
        }

        public void DeleteStudent(Student student)
        {
            _studentRepository.DeleteStudent(student);
        }

        public async Task<Student> GetStudentById(int studentId)
        {
            return await _studentRepository.GetStudentById(studentId);
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _studentRepository.GetStudents();
        }

        public Task<bool> SaveChangesToDbAsync()
        {
            return _studentRepository.SaveChangesToDbAsync();
        }

        public void UpdateStudent(Student student)
        {
            _studentRepository.UpdateStudent(student);
        }
    }
}
