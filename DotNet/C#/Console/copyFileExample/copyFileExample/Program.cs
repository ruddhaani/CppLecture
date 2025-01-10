using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace copyFileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = "C:\\Users\\praja\\OneDrive\\Desktop\\FilesExample\\sample.txt";
            string destinationFilePath = "C:\\Users\\praja\\OneDrive\\Desktop\\FilesExample\\sample3.txt";
            File.Copy(sourceFilePath, destinationFilePath,true);

        }
    }
}
