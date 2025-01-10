using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> obj = new Dictionary<int, string>();
            obj.Add(1, "cat");
            obj.Add(61, "dog");
            obj.Add(41, "tiger");
            obj.Add(14, "lion");
            obj.Add(13, "sparrow");
            obj.Add(12, "crow");
            if (obj.Count > 0)
            {
                foreach (var item in obj)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("count is " + obj.Count);
            }
            obj.Remove(1);
            if (obj.Count > 0)
            {
                foreach (var item in obj)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("count is " + obj.Count);
            }
            obj.Clear();
            Console.WriteLine("dictionary is clear count is :" + obj.Count);
        


        }
    }
}
