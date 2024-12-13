using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developerObj = new Developer();
            Console.WriteLine(developerObj.Name());
            Console.WriteLine(developerObj.Salary());
            Console.WriteLine(developerObj.CompanyName());
        }
    }
}
