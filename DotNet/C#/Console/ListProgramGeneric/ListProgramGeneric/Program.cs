using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProgramGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();  //name is an object 
            name.Add("Prajakta");
            name.Add("Dipika");
            name.Add("Pornima");
            //we can use foreach loop for printing
            foreach (string obj in name)
            {
                Console.WriteLine(obj);
            }

            ////or we print by accessing index
            //Console.WriteLine(name[0]);
            //Console.WriteLine(name[1]);
            //Console.WriteLine(name[2]);


        }
    }
}
