using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class School
    {
        public School() 
        {
            Console.WriteLine("School Constructor is called");
        }
        public void SchoolName(string schoolname)
        {
            Console.WriteLine(schoolname);
        }
    }
}
