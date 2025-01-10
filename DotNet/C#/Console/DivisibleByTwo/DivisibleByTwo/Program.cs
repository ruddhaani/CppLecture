using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleByTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int number=Convert.ToInt32(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine(number + " is divisble by 2");
            }
            else
            {
                Console.WriteLine(number+ " is not divisible by 2");
            }
        }
    }
}
