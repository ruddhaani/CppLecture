using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number from user");
            int number=Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i <= number/2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime ? "Prime" : "Not Prime");
        }
    }
}
