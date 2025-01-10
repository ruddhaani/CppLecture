using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fibonacci_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1=0, number2=1;
            int number3;
            int count=20;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            for(int i=2;i<count;i++)
            {
                number3=number1 + number2;
                Console.WriteLine(number3);
                number1 = number2;
                number2 = number3;
            }
            


        }
    }
}
