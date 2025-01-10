using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedListObj = new SortedList<int, string>();
            //SortedList1 sortedList = new SortedList1<int, string>();
            sortedList.Add(10, "Ab");
            sortedList.Add(20, "db");
            //sortedListObj.Add(1, "AAA");
            //sortedListObj.Add(4, "BBB");
            //sortedListObj.Add(45, "CCC");
            //sortedListObj.Add(2, "RRR");

            if(sortedList.Count > 0)
            {
                foreach (var list in sortedListObj)
                {
                    Console.WriteLine(list);
                    //Console.WriteLine("key is" + list.Key + " value is " + list.Value);

                }
            }
                Console.WriteLine("  count is "+sortedListObj.Count);

            //to remove
            sortedListObj.Remove(45);
            sortedListObj.Remove(2);
            if (sortedListObj.Count > 0)
            {
                foreach (var list in sortedListObj)
                {
                    Console.WriteLine(list);
                    //Console.WriteLine("key is" + list.Key + " value is " + list.Value);
                }
            }
            Console.WriteLine("  count is " + sortedListObj.Count);

            sortedListObj.RemoveAt(0);
            if (sortedListObj.Count > 0)
            {
                foreach (var list in sortedListObj)
                {
                    Console.WriteLine(list);
                }
            }
            Console.WriteLine("  count is " + sortedListObj.Count);

            sortedListObj.Clear();
            Console.WriteLine("for checking that sorted list is empty or not count is  "+sortedListObj.Count);

        }
    }
}
