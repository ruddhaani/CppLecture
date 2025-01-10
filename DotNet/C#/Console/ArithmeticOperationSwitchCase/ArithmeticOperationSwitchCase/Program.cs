
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperationSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, result;
            char choice;
            Console.WriteLine("Enter first number");
            number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            number2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a. Addition");
            Console.WriteLine("b. Subtraction");
            Console.WriteLine("c. Multiply");
            Console.WriteLine("d. Division");

            Console.WriteLine("Enter operation which you want to perform");
            choice=Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case 'a':
                    result = number1 + number2;
                    Console.WriteLine(result);
                    break;

                case 'b':
                    result= number1 - number2;
                    Console.WriteLine(result);
                    break;


                case 'c':
                    result = number1 * number2;
                    Console.WriteLine(result);
                    break;

                case 'd':
                    result = number1 / number2;
                    Console.WriteLine(result);
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
