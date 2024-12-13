using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> NameObj = new List<string>();
            NameObj.Add("Aniruddha");
            NameObj.Add("Rohit");
            NameObj.Add("Snehal");

            foreach(var i in NameObj)
            {
                Console.WriteLine(i);
            }
        }
    }
}
