using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(45>34)
            {
                Console.WriteLine("45 is greater than 34");
            }
            else
            {
                Console.WriteLine("45 is less than 34");
            }

            int x = 20;
            int y = 18;
            if(x>y)
            {
                Console.WriteLine("x is greater than y");
            }
            int time = 20;
            if(time<18)
            {
                Console.WriteLine("It is good time");
            }
            else
            {
                Console.WriteLine("It is bad time");
            }


            Console.WriteLine("enter your age");
                int age=Convert.ToInt32(Console.ReadLine());

            if(age>=18)
            {
                Console.WriteLine("Eligible for vote");

            }
            else
            {
                Console.WriteLine("Not Eligible for vote");
            }
        }
    }
}
