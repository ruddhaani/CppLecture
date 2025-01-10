using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number,result;
            Console.WriteLine("Enter number");
            number=Convert.ToInt32(Console.ReadLine());

            while(number<=0)
            {
                Console.WriteLine("invalid-number");
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(result=number * i );
            }
        }
    }
}
