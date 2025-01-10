using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj=new ArrayList();
            obj.Add(1);
            obj.Add(2);
            obj.Add(3);
            obj.Add("Prajakta");
            obj.Add(34.5);
            obj.Add("Developer");

            if (obj.Count > 0)
            {
                foreach (var elements in obj)
                {
                    Console.WriteLine(elements);
                }
                Console.WriteLine("count is " + obj.Count);
            }

            obj.Remove(3);      //value
            obj.RemoveAt(0);  //index
            Console.WriteLine("After deletion");
            if (obj.Count > 0)
            {
                foreach (var elements in obj)
                {
                    Console.WriteLine(elements);
                }
                Console.WriteLine("count is " + obj.Count);
            }

            obj.Clear();
            Console.WriteLine("Array list is clear count is : "+obj.Count);
        }
    }
}
