using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Company
    {
        protected string GetGSTNum()
        {
            return "Delloite";
        }
    }

    public class Employee : Company
    {
        public Employee() {
            Console.WriteLine(GetGSTNum());
        }
    }

    public class  Manager : Employee
    {
        public Manager()
        {
            Console.WriteLine(GetGSTNum());
        }

        private void GiveMe()
        {
            GetGSTNum();
        }
    }
}
