using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Employee : Company
    {
        public override void CompanyName()
        {
            Console.WriteLine("Meta");
        }
    }
}
