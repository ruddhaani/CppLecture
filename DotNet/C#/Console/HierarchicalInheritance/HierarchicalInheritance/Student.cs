using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    internal class Student:School
    {
        public Student() 
        {
            Console.WriteLine("Student constructor called");
        }

        public void StudentName(string studentName)
        {
            Console.WriteLine(studentName);
        }
    }
}
