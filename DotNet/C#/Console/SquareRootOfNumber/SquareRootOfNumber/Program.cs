using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRootOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number=Convert.ToInt32(Console.ReadLine());
            double squareRoot=Math.Sqrt(number);
            Console.WriteLine("Square Root of "+number+" is= "+squareRoot,number,squareRoot);

        }
    }
}
