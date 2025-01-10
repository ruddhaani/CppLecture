using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumberProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, reverse = 0;
            Console.WriteLine("Enter number");
            number=Convert.ToInt32(Console.ReadLine());
            while(number!=0)
            {
                reverse = reverse * 10;
                reverse = reverse + number % 10;
                number = number / 10;
            }
            Console.WriteLine("Reverse number is "+reverse);
        }
    }
}
