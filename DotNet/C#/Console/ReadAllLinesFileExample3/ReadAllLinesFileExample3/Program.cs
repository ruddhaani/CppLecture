using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadAllLinesFileExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllLines("D:\\DirectoryPracticalC#\\filename.txt").First());
        }
    }
}
