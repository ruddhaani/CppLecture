using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable countries = new Hashtable();
            countries.Add("Ind", "India");
            countries.Add("USA", "United States of America");
            countries.Add("UK", "United kingdom");
            countries.Add(10, "spain");
            if (countries.Count > 0)
            {
                foreach (DictionaryEntry country in countries)
                {
                    Console.WriteLine("key is "+country.Key+" value is "+country.Value);
                }
                Console.WriteLine("Total countries are :" + countries.Count);
            }
            Console.ReadLine();

            //to remove element
            countries.Remove("UK");
            if (countries.Count > 0)
            {
                foreach (DictionaryEntry country in countries)
                {
                    Console.WriteLine("key is " + country.Key + " value is " + country.Value);
                }
                Console.WriteLine("Total countries are :" + countries.Count);
            }



        }

        }
    }
