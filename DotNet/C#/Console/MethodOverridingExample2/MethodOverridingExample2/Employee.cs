using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExample2
{
    internal class Employee : Company
    {
        public override void CompanyExample()
        {
            Console.WriteLine("Child Class");
        }
    }
}
