using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePrac1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\CppLecture\\DotNet\\file.txt";

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Thick thighs , save lives");
            }

            using (StreamReader sr = new StreamReader(path, true))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
