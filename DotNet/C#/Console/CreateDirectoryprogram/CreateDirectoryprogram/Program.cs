using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateDirectoryprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderpath = "E:\\ppp";
            Directory.CreateDirectory(folderpath);

            string filepath1 = "E:\\ppp\\file.txt";
            File.Create(filepath1);


        }
    }
}
