using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateFileExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Create("D:\\DirectoryPracticalC#\\filename.txt");
        }
    }
}
