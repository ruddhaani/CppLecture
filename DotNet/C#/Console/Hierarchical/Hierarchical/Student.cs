using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical
{
    public class Student : School
    {
        public Student() 
        {
            Console.WriteLine("Student Constructor called");
        }

        public string StudentName { get; set; }    
    }
}
