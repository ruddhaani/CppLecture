using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackNonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack obj = new Stack(); 
            obj.Push("India");
            obj.Push(34);
            obj.Push(56);
            obj.Push("USA");
            obj.Push("UK");
            Console.WriteLine("Elements are ==");

            if (obj.Count > 0)
            {
                foreach (var element in obj)
                {
                    Console.WriteLine(element);
                }
                
            }
            //to remove element
            obj.Pop();
            if (obj.Count > 0)
            {
                foreach (var element in obj)
                {
                    Console.WriteLine(element);
                }

            }



        }
    }
}
