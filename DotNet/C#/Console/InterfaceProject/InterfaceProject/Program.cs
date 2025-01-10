using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager managerobj = new Manager();
            Console.WriteLine(managerobj.CompanyDetails());
            Console.WriteLine(managerobj.message());


        }
    }
}
