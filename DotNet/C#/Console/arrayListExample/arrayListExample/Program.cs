using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            obj.Add(1);
            obj.Add("Prajakta");
            obj.Add(2);
            obj.Add(45.6);
            obj.Add("Developer");
            obj.Add(3);
            obj.Add(4);
            obj.Add(5);
            obj.Add(6);

            if (obj.Count > 0)
            {
                foreach (var elements in obj)
                {
                    Console.WriteLine(elements);
                }
            }
            Console.WriteLine("count is "+obj.Count);

            obj.Remove("Developer");
            obj.Remove(45.6);
            obj.RemoveAt(3);


            if (obj.Count > 0)
            {
                foreach (var elements in obj)
                {
                    Console.WriteLine(elements);
                }
            }
            Console.WriteLine("count is " + obj.Count);

            obj.Clear();
            if (obj.Count == 0)
            {
                Console.WriteLine("Array List is Clear");
            }


        }
    }
}
