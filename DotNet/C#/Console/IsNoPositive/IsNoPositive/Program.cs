using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNoPositive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number=Convert.ToInt32(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine(number + " is positive no");
            }
            else
            {
                Console.WriteLine(number + "  is negative no");
            }
             
        }
    }
}
