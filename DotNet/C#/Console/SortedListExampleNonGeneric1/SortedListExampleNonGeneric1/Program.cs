using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListExampleNonGeneric1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedListObj = new SortedList();

            sortedListObj.Add(10, "Ten");
            sortedListObj.Add("Ten", 10);

            if(sortedListObj.Count > 0)
            {
                foreach (DictionaryEntry item in sortedListObj)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }
            }
        }
    }
}
