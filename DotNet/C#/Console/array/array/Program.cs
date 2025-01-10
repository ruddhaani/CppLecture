
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Array Example");
            int[] number = { 10, 20, 30 };
            Console.WriteLine("First number " + number[0]);
            Console.WriteLine("Second Number " + number[1]);
            Console.WriteLine("Third Number " + number[2]);
            Console.ReadLine();


            for (int i = 0; i < number.Length; i++)
            {

                Console.WriteLine(i);
            }

            //string[] name = { "abc", "def", "xyz" };
            string[] name = new string[] { "abc", "def", "xyz" };
            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
            Console.WriteLine(name[2]);

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine("array string example");
            string[] weekdayvalue = new string[7] { "Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "sun" };
            for (int i = 0; i < weekdayvalue.Length; i++)
            {
                Console.WriteLine("Array element index " + i + " value " + weekdayvalue[i]);
            }

            foreach(var day in weekdayvalue )
            {
                Console.WriteLine(day);
            }
           // ArrayList obj = new ArrayList();

            
           

            ArrayList Currencies = new ArrayList();
            Currencies.Add("INR");
            Currencies.Add("Dollar");
            foreach (var currency in Currencies )
            {
                Console.WriteLine(currency);
            }

            for (int i = 0;i < Currencies.Count;i++)
            {
                Console.WriteLine(Currencies[i]);
            }

        }
    }
}
