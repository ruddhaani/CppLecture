using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteFileExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.Create("D:\\Lecture\\DotNet\\C#\\Console\\WriteFileExample1\\WriteFileExample1\\textFile2.txt");

            string greeting = "Good Morning!";

            File.WriteAllText("D:\\Lecture\\DotNet\\C#\\Console\\WriteFileExample1\\WriteFileExample1\\textFile.txt" , greeting);
        }
    }
}
