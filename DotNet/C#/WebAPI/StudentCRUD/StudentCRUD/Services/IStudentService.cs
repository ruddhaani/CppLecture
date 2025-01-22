using StudentCRUD.Entities;

namespace StudentCRUD.Services
{
    public interface IStudentService
    {
        public Task<IEnumerable<Student>> GetStudents();

        public Task<Student> GetStudentById(int studentId);

        public Student AddStudent(Student student);

        public void UpdateStudent(Student student);

        public void DeleteStudent(Student student);

        public Task<bool> SaveChangesToDbAsync();
    }
}
