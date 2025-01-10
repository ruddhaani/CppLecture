using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable obj= new Hashtable();
            obj.Add(1, "aaa");
            obj.Add(2, "bbb");
            obj.Add(3, "ccc");
            obj.Add(4, "ddd");
            if (obj.Count > 0)
            {
                foreach (DictionaryEntry elements in obj)
                {
                    Console.WriteLine(elements.Value);
                }
                Console.WriteLine("count is " + obj.Count);
            }

            obj.Remove(1);
            obj.Remove(4);
            if (obj.Count > 0)
            {
                foreach (DictionaryEntry elements in obj)
                {
                    Console.WriteLine(elements.Value);
                }
                Console.WriteLine("count is " + obj.Count);
            }

            obj.Clear();
            Console.WriteLine("Hashtable is clear count is "+obj.Count);

        }
    }
}
