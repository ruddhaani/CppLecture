using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{
    internal class student:Teacher
    {
        public void Learn()
        {
            Console.WriteLine("Student is Learning");
        }
    }
}
