using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructorExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(19);
            Employee employee2 = new Employee(employee1);

            employee1.displayAge();
            employee2.displayAge();
        }
    }
}
