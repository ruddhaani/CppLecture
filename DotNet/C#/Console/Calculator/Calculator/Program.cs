using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 20;

            Arithmetic arithmeticObj = new Arithmetic();

            Console.WriteLine("Addition of two numbers is: " + arithmeticObj.AddTwoNumbers(firstNumber, secondNumber));

            Console.WriteLine("Subtraction of two numbers is: " + arithmeticObj.SubtractTwoNumbers(firstNumber, secondNumber));

            Console.WriteLine("Multiplication of two numbers is: " + arithmeticObj.MultiplyTwoNumbers(firstNumber, secondNumber));

            Console.WriteLine("Division of two numbers is: " + arithmeticObj.Divide(firstNumber, secondNumber));

        }

    }
}
