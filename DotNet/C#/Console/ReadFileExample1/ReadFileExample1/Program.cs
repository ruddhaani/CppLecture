using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFileExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.Create("D:\\Lecture\\DotNet\\C#\\Console\\ReadFileExample1\\ReadFileExample1\\fileExample.txt");

            //READ THE CONTENT OF THE FILE
            string path = "D:\\Lecture\\DotNet\\C#\\Console\\ReadFileExample1\\ReadFileExample1\\fileExample.txt";
            if (File.Exists(path))
            {
                //string count = File.ReadLines("D:\\Lecture\\DotNet\\C#\\Console\\ReadFileExample1\\ReadFileExample1\\fileExample.txt").First();
                //Console.WriteLine(count);

                //File.Copy(path, "D:\\Lecture\\DotNet\\C#\\Console\\ReadFileExample1\\ReadFileExample1\\fileExampleRenamed.txt");


                DateTime dt = File.GetCreationTime(path);
                Console.WriteLine(dt);
            }
        }
    }
}
