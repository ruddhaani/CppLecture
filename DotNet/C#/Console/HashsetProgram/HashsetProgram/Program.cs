using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashsetProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> obj= new HashSet<int>();
            obj.Add(10);
            obj.Add(25);
            obj.Add(56);
            obj.Add(45);
            if (obj.Count > 0)
            {
                foreach (int i in obj)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("count is " + obj.Count);
            }
            obj.Remove(56);
            obj.Remove(25);
            obj.Remove(45);
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
