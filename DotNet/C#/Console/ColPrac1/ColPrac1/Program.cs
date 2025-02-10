using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColPrac1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Lists

            //List<int> listObj = new List<int>();

            //listObj.Add(1);
            //listObj.Add(20);
            //listObj.Add(30);

            //foreach(var item in listObj)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary

            //Dictionary<int, string> dictionaryObj = new Dictionary<int, string>();

            //dictionaryObj.Add(1, "one");
            //dictionaryObj.Add(2, "two");
            //dictionaryObj.Add(3, "three");

            //foreach(var item in dictionaryObj)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //Console.WriteLine(dictionaryObj[2]);

            //dictionaryObj.Remove(2);

            //foreach (var item in dictionaryObj)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //Sorted List

            //Hashtables

            Hashtable hashtable = new Hashtable();

            hashtable.Add(1, "one");
            hashtable.Add(2, "two");
            hashtable.Add(3, "three");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
