using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample2
{
    internal static class Arithmetic
    {
        public static void Add(int a , int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
