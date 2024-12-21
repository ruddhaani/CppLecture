using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample3
{
    internal class Employee : Company
    {
        public Employee(string msg) : base(msg)
        {
            Console.WriteLine("This is employee constructor.");
        }
    }
}
