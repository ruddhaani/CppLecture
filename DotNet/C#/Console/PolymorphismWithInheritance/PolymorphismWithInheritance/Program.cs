using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismWithInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company companyObj = new Employee(1 , "Deloitte" , "Good");
        }
    }
}
