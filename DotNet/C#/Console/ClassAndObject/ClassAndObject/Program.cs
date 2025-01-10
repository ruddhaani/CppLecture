using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal obj = new Animal();
            obj.name = "Lion";
            obj.speak();
        }
    }
}
