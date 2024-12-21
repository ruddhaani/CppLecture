using System;
using System.IO;

namespace CreateFileExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a file
            File.Create("D:\\Lecture\\DotNet\\C#\\Console\\CreateFileExample1\\CreateFileExample1\\fileExample.txt");
            Console.WriteLine("file created");
        }
    }
}
