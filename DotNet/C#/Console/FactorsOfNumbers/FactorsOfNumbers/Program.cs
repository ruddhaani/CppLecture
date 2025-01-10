using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorsOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter number");
            number=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The factors are ==");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
