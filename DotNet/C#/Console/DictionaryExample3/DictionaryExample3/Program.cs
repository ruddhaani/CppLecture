using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dictionaryObj = new Dictionary<int, int>();

            dictionaryObj.Add(1, 2);
            dictionaryObj.Add(2, 3);
            dictionaryObj.Add(3, 4);

            if(dictionaryObj.Count > 0)
            {
                foreach(var item in dictionaryObj)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }
            }
        }
    }
}
