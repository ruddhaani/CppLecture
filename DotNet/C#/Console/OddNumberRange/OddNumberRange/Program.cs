using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumberRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number of range");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number of range");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Odd numbers are");
            for (int i = number1; i <= number2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    
}
