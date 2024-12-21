using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueObj = new Queue<int>();

            queueObj.Enqueue(10);
            queueObj.Enqueue(20);
            queueObj.Enqueue(30);

            queueObj.Dequeue();

            if(queueObj.Count > 0)
            {
                foreach (var item in queueObj)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
