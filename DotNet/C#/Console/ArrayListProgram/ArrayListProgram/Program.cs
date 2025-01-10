using System;
using System.Collections;
//remove and sort using we can clear unnecessary program files in project.
namespace ArrayListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList countries= new ArrayList() { "India", "USA", "UK"};
            Console.WriteLine("Display countries Name");
            countries.Add("Japan");
            if (countries.Count > 0)
            {
                foreach (string country in countries)
                {
                    Console.WriteLine(country);
                    
                }
                Console.WriteLine(countries.Count);
            }
            countries.Remove("USA");

            Console.WriteLine("updated countries after deletion");
            if (countries.Count > 0)
            {
                foreach (string country in countries)
                {
                    Console.WriteLine(country);
                }
                Console.WriteLine(countries.Count);
            }
            countries.Insert(3, "Germany");
            Console.WriteLine("After adding one more country");
            if (countries.Count > 0)
            {
                foreach (string country in countries)
                { Console.WriteLine(country); }
            }


        }
    }
}
