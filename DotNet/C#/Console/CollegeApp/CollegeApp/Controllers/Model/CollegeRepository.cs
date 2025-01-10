namespace CollegeApp.Controllers.Model
{
    public static class CollegeRepository
    {
        public static List<Student> students {  get; set; } = new List<Student> {
             new Student
           {
               Id = 1,
               StudentName = "aaaaa",
               Email = "student1@gmail.com",
               Address = "Maharashtra, India"
           },
             new Student
             {
                 Id = 2,
                 StudentName = "bbb",
               Email = "student2@gmail.com",
               Address = "Gujrat, India"

             },

           };
    }
}
