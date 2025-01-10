using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeleteProjectExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Delete("C:\\Users\\praja\\OneDrive\\Desktop\\FilesExample\\sample2.txt");
            Console.WriteLine("file is deleted");
        }
    }
}
