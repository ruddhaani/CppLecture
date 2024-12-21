using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AppendFileExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText("D:\\DirectoryPracticalC#\\filename.txt" , "Hello Again!");
        }
    }
}
