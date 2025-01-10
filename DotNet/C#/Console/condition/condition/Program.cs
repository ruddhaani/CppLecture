using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("enter number");
            //int number=Convert.ToInt32(Console.ReadLine());
            //if(number%2==0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}

            Console.WriteLine("Enter first number");
            int number1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            (number1 > number2) ? Console.WriteLine("Number is greater") : ConsoleWriteLine("Number is small");



        }
    }
}
