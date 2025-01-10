using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    public class Employee : AccountInformation    //derived class 
    {
        public Employee() 
        {
            Console.WriteLine("Employee Constructor");
        }

        public string Name { get; set; }

    }
}
