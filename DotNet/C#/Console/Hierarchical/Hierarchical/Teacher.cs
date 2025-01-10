using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical
{
    public class Teacher : School
    {
        public Teacher() 
        {
            Console.WriteLine("Teacher Constructor Called");
        }

        public string TeacherName { get; set; }
    }
}
