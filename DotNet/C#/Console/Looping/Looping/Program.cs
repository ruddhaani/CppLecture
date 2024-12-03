using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 10, 20, 30, 40, 50 };

            //int[] num1 = new int[6];

            //String[] strarr1= new String[] { "Aniruddha", "New", "New" };

            string[] strarray = { "Aniruddha", "Prathamesh", "Chakuli", "Khuni" };

            Console.WriteLine("Number array: ");

            //for loop

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("index " + i + " : " + num[i]);
            }

            Console.WriteLine();

            Console.WriteLine("String array: ");

            //string array for loop

            for (int i = 0; i < strarray.Length; i++)
            {
                Console.WriteLine(strarray[i]);
            }

            //String array foreach loop

            Console.WriteLine();
            Console.WriteLine("ForEach code : ");

            foreach (var i in strarray)
            {
                Console.WriteLine(i);
            }


            //ArrayList

            ArrayList currency = new ArrayList();
            currency.Add("INR");
            currency.Add("USD");
            currency.Add(10);

            Console.WriteLine();
            Console.WriteLine("ForEach code of currency : ");

            //Foreach arraylist code
            foreach (var cur in currency)
            {
                Console.WriteLine(cur);
            }

            Console.WriteLine();

            //For loop arraylist code

            for (int i = 0; i < currency.Count; i++)
            {
                Console.WriteLine(currency[i]);
            }

            //While loop

            Console.WriteLine();
            Console.WriteLine("While loop");

            int k = 0;

            while (k < 5)
            {
                Console.WriteLine(k);
                k++;
            }

            Console.WriteLine();
            Console.WriteLine("Do while loop");

            int x = 0;

            do
            {
                Console.WriteLine(x);
                x++;
            }while (x < 5);
        }
    }
}
