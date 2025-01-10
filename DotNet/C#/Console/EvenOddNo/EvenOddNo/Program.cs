using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine(number+ " is Even");

            }
            else
            {
                Console.WriteLine(number + " is Odd");
            }

        }
    }
}
