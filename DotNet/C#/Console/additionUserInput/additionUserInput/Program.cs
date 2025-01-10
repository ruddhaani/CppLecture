using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additionUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Name ");
            string name = Console.ReadLine();     //function where we can get data from user
            Console.WriteLine(name);
            


            Console.WriteLine("Enter character from user ");
            char name1 = 'A';
            Console.WriteLine("character is " + name1);

            Console.WriteLine("Enter integer number from user");
            int number = 121;
            Console.WriteLine("Integer number is " + number);

            Console.WriteLine("Enter character");
            char ch=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("character is " + ch);
            Console.WriteLine();

            Console.WriteLine("Enter number from user");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number is " + number1);

            Console.WriteLine("Enter decimal number from user");
            float number2=Convert.ToSingle(Console.ReadLine());


            

        }
    }
}
