using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace StreamExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "D:\\DirectoryPracticalC#\\filename.txt";
            //using (StreamWriter sw = new StreamWriter(filepath)) {
            //   sw.WriteLine("This is");
            //}

            using (StreamReader sr = new StreamReader(filepath))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
