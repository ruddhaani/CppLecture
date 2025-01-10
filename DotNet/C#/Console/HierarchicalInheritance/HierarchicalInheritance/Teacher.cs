using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    internal class Teacher :School
    {
        public Teacher()
        {
            Console.WriteLine("Teacher constructor called");
        }

        public void Teachername(string TeacherName)
        {
            Console.WriteLine(TeacherName);
        }
    }
}
