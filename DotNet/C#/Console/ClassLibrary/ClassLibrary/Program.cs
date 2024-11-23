using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arithmetic;
using Calculator;

namespace ClassLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cal obj = new Cal();
            Maths mathObj = new Maths();
      

            Console.WriteLine("Addition: " + obj.Addition(1,2));
            Console.WriteLine("Message: "+ mathObj.GetMessage());
            Console.WriteLine("Subtraction: " + mathObj.Subtraction(2,1));
            Console.WriteLine("Multiplication: " + mathObj.Multiplication(2,2));
            Console.WriteLine("Division: " + mathObj.Divide(22,4));

        }
    }
}
