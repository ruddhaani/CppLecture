using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    internal class Developer : ICompany , IEmployee
    {
        public string Name()
        {
            return "Aniruddha";
        }

        public int EmployeeID()
        {
            return 1;
        }

        public float Salary()
        {
            return 32492;
        }

        public string CompanyName()
        {
            return "Google";
        }
    }
}
