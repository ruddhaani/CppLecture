using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Manipulation manipulationObj = new Manipulation();

            Console.WriteLine("Enter how you wanna greet the user: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the name of user: ");
            string greeting = Console.ReadLine();

            Console.WriteLine("Concat: " + manipulationObj.ConcatString(greeting, name));


            string name1 = "Aniruddha";
            string name2 = "Prathamesh";

            string fullName = "Aniruddha Ramane";

            manipulationObj.ReplaceTwoStrings(name1, name2);
            Console.WriteLine(name1);

            Console.WriteLine("Upper case: " + manipulationObj.ChangeToUpperCase(name1));

            Console.WriteLine("Lower case: " + manipulationObj.ChangeToLowerCase(name1));

            Console.WriteLine(fullName.Trim());
        }
    }
}
