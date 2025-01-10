using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadSingleLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to read all lines in file
            string content = File.ReadAllText("C:\\Users\\praja\\OneDrive\\Desktop\\FilesExample\\sample3.txt");
            Console.WriteLine(content);

            //to read single line in file

            string filepath = "C:\\Users\\praja\\OneDrive\\Desktop\\FilesExample\\sample3.txt";

            string[] lines = File.ReadAllLines(filepath);
            if (lines.Length > 0)
            {
                string firstLine = lines[0];
                Console.WriteLine(firstLine);
            }
            else
            {
                Console.WriteLine("File is empty");
            }
        }
    }
}
