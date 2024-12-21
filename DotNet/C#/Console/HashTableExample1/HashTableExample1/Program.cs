using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable country = new Hashtable();
            country.Add("IND", "India");
            country.Add("US", "United States");
            country.Add("UK", "United Kingdom");

            
            if(country.Count > 0)
            {
                foreach (DictionaryEntry item in country)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }
            }
        }
    }
}
