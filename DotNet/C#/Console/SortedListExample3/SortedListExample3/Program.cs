using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> signalObj = new SortedList<string, int>();

            signalObj.Add("Red", 1);
            signalObj.Add("Blue", 2);
            signalObj.Add("Green", 3);

            //signalObj.Remove("Blue");
            signalObj.RemoveAt(0);

            signalObj.Add("Yellow", 2);

            if(signalObj.Count > 0)
            {
                foreach (var item in signalObj)
                {
                    Console.WriteLine(item.Key + " : " + item.Value);
                }
            }

        }
    }
}
