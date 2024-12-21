using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample2
{
    internal class Employee : Company
    {
        public Employee()
        {
            Console.WriteLine("This is Employee class.");
        }
    }
}
