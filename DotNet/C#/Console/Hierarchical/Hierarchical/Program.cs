using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Teacher teacher = new Teacher();

            student.SchoolName = "My Tech Focus";
            student.StudentName = "Prajakta";

            teacher.SchoolName = "My Tech Focus";
            teacher.TeacherName = "Saurabh Sir";

            Console.WriteLine("School name is "+student.SchoolName);
            Console.WriteLine("Student name is "+student.StudentName);

            Console.WriteLine("School Name is "+teacher.SchoolName);
            Console.WriteLine("Teacher Name is "+teacher.TeacherName);

            
            

        }
    }
}
