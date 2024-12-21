using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateDirectoryExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory("D:\\SnehalIsBeautiful");

            Directory.CreateDirectory("D:\\SnehalIsBeautiful\\ReallyPretty");

            using (File.Create("D:\\SnehalIsBeautiful\\ReallyPretty\\snehal.txt")) { }

            File.WriteAllText("D:\\SnehalIsBeautiful\\ReallyPretty\\snehal.txt", "Snehal is pretty cute");


        }
    }
}
