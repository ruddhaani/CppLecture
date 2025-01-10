using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListNonGeneric
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                SortedList countries = new SortedList();
                countries.Add(45, "India");
                countries.Add(67, "United States of America");
                countries.Add(34, "United kingdom");
                countries.Add(11, 78);
            countries.Add(8, "spain");
                if (countries.Count > 0)
                {
                    foreach (DictionaryEntry country in countries)
                    {
                        Console.WriteLine("key is " + country.Key + " value is " + country.Value);
                    }
                    Console.WriteLine("Total countries are :" + countries.Count);
                }
                Console.ReadLine();



                //to remove element
                countries.Remove(11);
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

