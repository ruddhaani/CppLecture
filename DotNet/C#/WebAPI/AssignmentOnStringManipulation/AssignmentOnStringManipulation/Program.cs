using System;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentOnStringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "abc-abc-abc <= Pub-RetMNF <= Pub-RetRTQ <= Pub-RetRRQ";

            string valueDuplicate = "";
            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < value.Length; i++)
            {

                if (value[i] == ' ')
                {
                    if (!string.IsNullOrWhiteSpace(valueDuplicate) && valueDuplicate != "<=")
                    {
                        queue.Enqueue(valueDuplicate);
                    }
                    valueDuplicate = "";
                }
                else
                {
                    valueDuplicate += value[i];
                }
            }

            if (!string.IsNullOrWhiteSpace(valueDuplicate) && valueDuplicate != "<=")
            {
                queue.Enqueue(valueDuplicate);
            }


            for(int i = 0; i<queue.Count; i++)
            {
                string temp = queue.Dequeue();

                for(int j = 0; j<queue.Count; j++)
                {
                    Console.WriteLine($"{temp}*{queue.ElementAt(j)}");
                }

                queue.Enqueue(temp);
            }
        }
    }
}
