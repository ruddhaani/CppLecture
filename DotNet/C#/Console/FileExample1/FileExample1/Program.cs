using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\DirectoryPracticalC#\\newfile.txt";

            //File.Create(filePath);

            File.AppendAllText(filePath, "This is new file");

            Console.WriteLine(File.ReadAllText(filePath));

            
        }
    }
}
