using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructorExample
{
    internal class Employee
    {
        public int Age{ get; set; }
        public Employee()
        {
            Age = 18;
        }

        public Employee(Employee E)
        {
            this.Age = E.Age;
        }
    }
}
