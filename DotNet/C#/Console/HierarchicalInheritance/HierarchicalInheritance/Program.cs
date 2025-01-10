using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student studentObj= new Student();
            studentObj.StudentName("Prajakta");
            studentObj.SchoolName("My tech focus");

            Teacher teacherObj= new Teacher();
            teacherObj.Teachername("Saurabh sir");
            teacherObj.SchoolName("My tech focus");

        }
    }
}
