using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList obj = new SortedList();
            obj.Add(10, "india");
            obj.Add(45, "usa");
            obj.Add(5, "uk");
            obj.Add(651, "africa");
            obj.Add(165, "japan");
            obj.Add(7, "china");
            if (obj.Count > 0)
            {
                foreach (DictionaryEntry item in obj)
                {
                    Console.WriteLine(item.Key + " " + item.Value);

                }
                Console.WriteLine("count is " + obj.Count);
            }
            obj.Remove(651);
            obj.Remove(5);
            obj.Remove(165);
            obj.Remove(7);
            Console.WriteLine("After deletion--- ");
            if (obj.Count > 0)
            {
                foreach (DictionaryEntry item in obj)
                {
                    Console.WriteLine(item.Key + " " + item.Value);

                }
                Console.WriteLine("count is " + obj.Count);
            }

        }
    }
}
