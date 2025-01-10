using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorCalling
{
    public class Company
    {
        public Company()
        {
            Console.WriteLine("Base Constructor called");
        }

        ~Company()
        {
            Console.WriteLine("Base Destructor called");
        }
    }
}
