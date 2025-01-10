using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel
{
    public class Developer : Employee
    {
        public Developer() 
        {
            Console.WriteLine("Developer class constructor called");
        }

        public string ProjectName {  get; set; }
    }
}
