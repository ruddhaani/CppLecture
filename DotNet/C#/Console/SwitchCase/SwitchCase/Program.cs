﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {

                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Input correct day of the week");
                    break;

            }

            Console.WriteLine("Enter a number: ");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
        }
    }
}
