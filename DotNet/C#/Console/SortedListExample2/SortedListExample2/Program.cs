using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedListObj = new SortedList<int, string>();

            sortedListObj.Add(1, "Red");
            sortedListObj.Add(2, "Blue");
            sortedListObj.Add(3, "Green");

            sortedListObj.Remove(2);

            sortedListObj.Add(2, "Purple");

            if(sortedListObj.Count > 0)
            {
                foreach (var item in sortedListObj)
                {
                    Console.WriteLine(item.Key + " : " + item.Value);
                }
            }
        }
    }
}
