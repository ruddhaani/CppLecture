using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> obj = new Queue<int>(); 
            obj.Enqueue(100);
            obj.Enqueue(200);
            obj.Enqueue(300);
            Console.WriteLine("Queue elements are");
            if (obj.Count > 0)
            {
                foreach (int value in obj)
                {
                    Console.WriteLine(value);
                }
                Console.WriteLine("count is " + obj.Count);
            }
            Console.ReadLine();


            obj.Dequeue();
            Console.WriteLine("Queue elements are");
            if (obj.Count > 0)
            {
                foreach (int value in obj)
                {
                    Console.WriteLine(value);
                }
                Console.WriteLine("count is "+obj.Count);
            }

             
        }
    }
}
