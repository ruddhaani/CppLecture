using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFileCountExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string baseDir = "D:\\DirectoryPracticalC#\\Example1\\KYC\\";

            string[] fileDetails = Directory.GetFiles(baseDir);

            Console.WriteLine(Directory.GetFiles(baseDir).Count());

            foreach(var i in fileDetails)
            {
                Console.WriteLine(i);
            }
        }
    }
}
