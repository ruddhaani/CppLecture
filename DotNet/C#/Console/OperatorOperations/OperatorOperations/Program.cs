using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 40;
            Console.WriteLine("addition is ="+ (a + b));
            Console.WriteLine("subtraction is =" + (a - b));

            Console.WriteLine("multiplication is =" + (a * b));
            Console.WriteLine("division is =" + (a / b));
            Console.WriteLine("modulus is =" + (a % b));

            Console.WriteLine("increment in value of a is  " + (a++));
            Console.WriteLine("increment in value of a is  " + (++a));
            Console.WriteLine("increment in value of b is  " + (b++));
            Console.WriteLine("increment in value of b is  " + (++b));

            Console.WriteLine("Decrement in value of a is " + (a--));
            Console.WriteLine("Decrement in value of a is " + (--a));
            Console.WriteLine("Decrement in value of a is " + (b--));
            Console.WriteLine("Decrement in value of b is " + (--b));

            bool result;
            result=(a==b);
            Console.WriteLine("Equal to operator" + result);
            Console.WriteLine("Greater than operator" + result);
            Console.WriteLine("Less than operator" + result);
            Console.WriteLine("Less than equal to operator" + result);
            Console.WriteLine("Greater than equal to operator" + result);

            bool x = true;
            bool y = false;
            
            Console.WriteLine("AND operator "+(x && y));
            Console.WriteLine("OR operator " + (x || y));
            Console.WriteLine("NOT operator " + (!x));
            Console.WriteLine("NOT operator " + (!y));




        }
    }
}
