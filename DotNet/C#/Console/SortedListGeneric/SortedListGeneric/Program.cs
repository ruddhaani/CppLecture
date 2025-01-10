using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,string> obj= new SortedList<int,string>();
            obj.Add(10, "aaa");
            obj.Add(91, "bgf");
            obj.Add(71, "rfr");
            obj.Add(78, "trgf");
            obj.Add(4, "hgrf");
            if (obj.Count > 0)
            {
                foreach (var item in obj)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("count is " + obj.Count);
            }
            obj.Remove(10);
            obj.Remove(4);
            Console.WriteLine("After deletion");
            if (obj.Count > 0)
            {
                foreach (var item in obj)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("count is " + obj.Count);
            }

        }
    }
}
