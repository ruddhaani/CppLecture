using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy3and5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int number=Convert.ToInt32(Console.ReadLine());
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine(number + " is divisible by 3 and 5");
            }
            else
            {
                Console.WriteLine(number + " is not divisible by 3 and 5");
            }
        }
    }
}
