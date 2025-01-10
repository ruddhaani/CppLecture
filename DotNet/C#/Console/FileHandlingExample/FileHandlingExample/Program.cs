using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File create Example");
            File.Create("C:\\Users\\praja\\OneDrive\\Desktop\\FilesExample\\firstFile.txt");
            Console.WriteLine("File Created");

            
        }
    }
}
