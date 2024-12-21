using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeleteFileExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Delete("D:\\DirectoryPracticalC#\\filename2.txt");
        }
    }
}
