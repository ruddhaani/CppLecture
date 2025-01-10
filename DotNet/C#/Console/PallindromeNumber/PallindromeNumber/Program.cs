using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PallindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, reverse = 0;
            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());
            int temp=number;
            while (temp != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + temp % 10;
                temp = temp / 10;
            }
            Console.WriteLine("Reverse number is " + reverse);
            if (number == reverse)
            {
                Console.WriteLine(number+" is pallindrome",number);
            }
            else
            {
                Console.WriteLine(number + " is not pallindrome", number);
            }
        }
    }
}
