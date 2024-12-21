using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteFileExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("D:\\DirectoryPracticalC#\\filename.txt", "Hello!");
        }
    }
}
