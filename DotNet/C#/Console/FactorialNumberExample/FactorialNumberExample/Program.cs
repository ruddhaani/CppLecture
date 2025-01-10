using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumberExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number,fact=1;
            Console.WriteLine("Enter number");
            number=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of "+number+"is =="+ fact);


        }
    }
}
