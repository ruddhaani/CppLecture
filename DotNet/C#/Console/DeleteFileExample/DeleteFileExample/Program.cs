using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteFileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //file deleted
            File.Delete("D:\\Lecture\\DotNet\\C#\\Console\\CreateFileExample1\\CreateFileExample1\\fileExample.txt");
            Console.WriteLine("File Deleted");
        }
    }
}
