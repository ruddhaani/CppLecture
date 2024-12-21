using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionaryObj = new Dictionary<string, string>();

            dictionaryObj.Add("Red", "Stop");
            dictionaryObj.Add("Yello", "Warning");
            dictionaryObj.Add("Green", "Go");

            if(dictionaryObj.Count  > 0)
            {
                foreach (var item in dictionaryObj)
                {
                    Console.WriteLine(item.Key + " : " + item.Value);

                }
            }
        }
    }
}
