using Microsoft.EntityFrameworkCore;
using StudentCRUD.Data;
using StudentCRUD.Entities;

namespace StudentCRUD.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;

        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public Student AddStudent(Student student)
        {
            _context.Students.Add(student);
            return student;
        }

        public void DeleteStudent(Student student)
        {
            _context.Students.Remove(student);
        }

        public async Task<Student> GetStudentById(int studentId)
        {
            return await _context.Students.FirstOrDefaultAsync(x => x.StudentId == studentId);
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void UpdateStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
        }
    }
}
