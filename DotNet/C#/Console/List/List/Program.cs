using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listObj=new List<int>();  
            listObj.Add(1);
            listObj.Add(2); 
            listObj.Add(3);
                
            listObj.Add(4);
            listObj.Add(5);
            listObj.Add(6);
            listObj.Add(7);

            listObj.Add(8);

            if (listObj.Count > 0)
            {
                foreach (int value in listObj)
                {
                    Console.WriteLine(value);
                }
            }
            Console.WriteLine("count is "+listObj.Count);

            listObj.RemoveAt(4);
            if (listObj.Count > 0)
            {
                foreach (int value in listObj)
                {
                    Console.WriteLine(value);
                }
            }
            Console.WriteLine("count is " + listObj.Count);
            
            listObj.Remove(4);
            if (listObj.Count > 0)
            {
                foreach (int value in listObj)
                {
                    Console.WriteLine(value);
                }
            }
            Console.WriteLine("count is " + listObj.Count);

            listObj.RemoveRange(3, 3);
            if (listObj.Count > 0)
            {
                foreach (int value in listObj)
                {
                    Console.WriteLine(value);
                }
            }
            Console.WriteLine("count is " + listObj.Count);

            listObj.Clear();
            Console.WriteLine("After clearing it is empty "+listObj.Count);



        }
    }
}
