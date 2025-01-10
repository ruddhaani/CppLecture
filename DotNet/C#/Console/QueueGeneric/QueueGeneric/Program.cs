using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<double> obj= new Queue<double>();
            obj.Enqueue(41.60);
            obj.Enqueue(56.65);
            obj.Enqueue(78.65);
            obj.Enqueue(45.7);
            obj.Enqueue(34.567);
            obj.Enqueue(3.456);

            if (obj.Count > 0)
            {
                foreach (var item in obj)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("count is " + obj.Count);
                Console.WriteLine("peek element is " + obj.Peek());
            }
            obj.Dequeue();
            obj.Dequeue();
            Console.WriteLine("after deletion ==");
            if (obj.Count > 0)
            {
                foreach (var item in obj)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("count is " + obj.Count);
                Console.WriteLine("peek element is " + obj.Peek());
            }
        }
    }
}
