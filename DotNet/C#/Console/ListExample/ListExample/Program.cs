using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> obj = new List<int>();
            obj.Add(16);
            obj.Add(299);
            obj.Add(35);
            obj.Add(46);
            obj.Add(54);
            obj.Add(63);
            obj.Add(75);

            if (obj.Count > 0)
            {
                foreach (int i in obj)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("count is " + obj.Count);
            }
            Console.WriteLine("After deletion ---");
            obj.Remove(299);
            obj.RemoveAt(0);
            obj.RemoveAt(1);

            if (obj.Count > 0)
            {
                foreach (int i in obj)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("count is " + obj.Count);
            }

        }
    }
}
