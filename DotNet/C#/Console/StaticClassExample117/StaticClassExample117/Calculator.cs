using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample117
{
    public static class Calculator
    {
        static Calculator()
        {
            Console.WriteLine("Static Class Constructor");
        }

        public static void Add(int a , int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
