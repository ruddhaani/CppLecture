using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtableprogram3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable obj = new Hashtable();
            obj.Add(1, "prajakta");
            obj.Add(2, 34);
            obj.Add(4, "aa");
            obj.Add(34, "dfdfdf");
            obj.Add(32, 'a');
            if (obj.Count > 0)
            {
                foreach (DictionaryEntry elements in obj)
                {
                    Console.WriteLine(elements.Value);
                }
                Console.WriteLine("count is " + obj.Count);
            }
            Console.WriteLine("After Deletion output is ---");
            obj.Remove(1);
            obj.Remove(2);

            if (obj.Count > 0)
            {
                foreach (DictionaryEntry elements in obj)
                {
                    Console.WriteLine(elements.Value);
                }
                Console.WriteLine("count is " + obj.Count);
            }
            obj.Clear();
            Console.WriteLine("Hashtable is clear count is " + obj.Count);
        
        
        }
    }
}
