using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "E:\\KYC\\Test.txt";
            using (StreamWriter sw = new StreamWriter(filepath)) 
            {
                sw.WriteLine("this is Prajakta");
                sw.WriteLine("this is dipika");
                
            }
            using (StreamReader sr = new StreamReader(filepath))
            {
                Console.WriteLine(sr.ReadToEnd());
                //Console.WriteLine(sr.ReadLine());


            }

           
        }
    }
}
