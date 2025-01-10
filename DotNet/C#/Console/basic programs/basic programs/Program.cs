using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hello worlld program
            Console.Write("Hello World");
            Console.Write("This is my first c# program");
            Console.WriteLine("c# Rockstar");
            Console.WriteLine("AI Rockstar");

            //name
            Console.WriteLine("Enter Name ");
            string name = Console.ReadLine();     //function where we can get data from user
            Console.WriteLine(name);
           
            //character
            char name1 = 'A';
            Console.WriteLine("character is " + name1);
            
            //integer
            int number = 121;
            Console.WriteLine("Integer number is " + number);

            //float
            float number1 = 10.4f;
            Console.WriteLine("Float number is " +number1);

            //double
            double number2 = 10.432;
            Console.WriteLine("Double number is " + number2);

            //bool
            bool isStudent=true;
            bool isStudent2=false;
            Console.WriteLine(isStudent);
            Console.WriteLine(isStudent2);

            //long
            long number3 = 124543544535334534;
            Console.WriteLine("Long integer number is " + number3);





        }
    }
}
