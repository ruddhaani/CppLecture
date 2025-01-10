using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> obj = new Dictionary<int, string>();
            obj.Add(9, "AAA");
            obj.Add(5, "BBB");
            obj.Add(3, "CCC");
            obj.Add(4, "DDD");
            Console.WriteLine("Initial Dictionary");
            if (obj.Count > 0)
            {
                foreach (var item in obj)
                {
                    //Console.WriteLine(item);
                    Console.WriteLine("key is " + item.Key + "value is " + item.Value);
                }
            }
            Console.WriteLine("count is "+obj.Count);
            obj.Remove(4);
            Console.WriteLine("\nafter deletion");
            if (obj.Count > 0)
            {
                foreach (var item in obj)
                {
                    Console.WriteLine(item);
                }
            }

            obj.Clear();
            Console.WriteLine("After clearing count is " + obj.Count);

        }
    }
}
