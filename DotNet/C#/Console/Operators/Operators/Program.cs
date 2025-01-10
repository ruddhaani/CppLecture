using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 400 + 50;
            int sum2 = sum1 + 50;
            int sum3=sum2+sum2;
            Console.WriteLine("sum1 =" + sum1);
            Console.WriteLine("sum 2 is " + sum2);
            Console.WriteLine("sum 3 is " + sum3);

            int sub = 78 - 45;
            Console.WriteLine("subtraction is" + sub);

            int x = 10;
            x += 20;
            Console.WriteLine("value of x is " +x);

            int y = 50;
            y *= 4;
            Console.WriteLine("value of y is " + y);

            int a = 45, b = 36;
            Console.WriteLine(a > b);

            Console.WriteLine(true && false);
            Console.WriteLine(true || true);

            
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(45, 34));
            Console.WriteLine(Math.Sqrt(49));
            Console.WriteLine(Math.Abs(-45.4)); //return positive value
            Console.WriteLine(Math.Round(45.69));




        }
    }
}
