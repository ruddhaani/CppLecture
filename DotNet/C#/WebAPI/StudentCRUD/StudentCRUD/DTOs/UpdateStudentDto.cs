namespace StudentCRUD.DTOs
{
    public class UpdateStudentDto
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Department { get; set; }
    }
}
