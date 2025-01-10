using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Aniruddha\\filename.txt";
            
            using (StreamWriter sw = new StreamWriter(path , true))
            {
                sw.WriteLine("Thick Thighs , Save Lives");
            }

            using (StreamReader sr = new StreamReader(path , true))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
