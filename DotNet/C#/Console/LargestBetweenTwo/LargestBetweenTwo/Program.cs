using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestBetweenTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int number2=Convert.ToInt32(Console.ReadLine());
            if(number1>number2)
            {
                Console.WriteLine(number1+" " + "is greater than "+number2);
            }
            else
            {
                Console.WriteLine(number2 + " " + "is greater than " + number1);

            }
        }
    }
}
