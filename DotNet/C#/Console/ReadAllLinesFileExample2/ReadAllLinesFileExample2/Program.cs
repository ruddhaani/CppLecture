using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ReadAllLinesFileExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.Create("D:\\DirectoryPracticalC#\\filename.txt")

            //File.WriteAllText("D:\\DirectoryPracticalC#\\filename.txt", "Hello!");

            Console.WriteLine(File.ReadAllLines("D:\\DirectoryPracticalC#\\filename.txt").First());
         
        }
    }
}
