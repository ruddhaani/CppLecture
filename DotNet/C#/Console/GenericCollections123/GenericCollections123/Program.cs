using System;
using System.Collections.Generic;

namespace GenericCollections123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    List<int> listObj = new List<int>();
            //    listObj.Add(10);
            //    listObj.Add(20);

            //    foreach(var item in listObj)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Dictionary<int, string> dictionaryObj = new Dictionary<int, string>();
            //dictionaryObj.Add(10, "Aniruddha");
            //dictionaryObj.Add(5, "Sejal");
            //dictionaryObj.Add(1, "Shubham");

            //foreach (var item in dictionaryObj)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //SortedList<int, string> sortedListObj = new SortedList<int, string>();

            //sortedListObj.Add(10, "Aniruddha");
            //sortedListObj.Add(5, "Shubham");
            //sortedListObj.Add(7, "Anand");


            //foreach (var item in sortedListObj)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(30);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


        }
    }
}
