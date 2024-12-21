using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample3
{
    internal class Company
    {
        public Company(string msg)
        {
            Console.WriteLine("This is " + msg + " Constructor.");
        }
    }
}
