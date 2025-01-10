using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel
{
    public class Employee : Person
    {
        public Employee()
        {
            Console.WriteLine("Employee class Constructor called");
        }

        public int salary {  get; set; }
    }
}
