using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_C_Sharp_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition of " + firstNumber + " and " + secondNumber + " is " + (firstNumber + secondNumber));

        }
    }
}
