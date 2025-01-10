using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace DeleteFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Delete file example");
            //File.Delete("C:\\Users\\praja\\OneDrive\\Desktop\\FilesExample\\firstFile.txt");

            Console.WriteLine("create file example");
            File.Create("C:\\Users\\praja\\OneDrive\\Desktop\\FilesExample\\firstFile.txt");
            

            string filepath = "C:\\Users\\praja\\OneDrive\\Desktop\\FilesExample\\firstFile.txt";
            string content = "this is file";
            File.WriteAllText(filepath, content);


            //string content = "I am Prajakta";
            //File.WriteAllText(filepath, content);
            //Console.Write("File create and write");

            string filePath = "C:\\Users\\praja\\OneDrive\\Desktop\\FilesExample\\firstFile.txt";
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine(fileContent);

            //if (File.Exists(filePath))
            //{


            //    //string fileContent = File.ReadLines(filePath);
            //    foreach (string line in File.ReadLines(filePath))
            //    {
            //        Console.WriteLine(line);
            //    }
            //}

            //copy file
            string sourceFilePath = "C:\\Users\\praja\\OneDrive\\Desktop\\FilesExample\\firstFile.txt";
            string destinationFilepath = "C:\\Users\\praja\\OneDrive\\Desktop\\FilesExample\\firstFile1.txt";

            File.Copy(sourceFilePath, destinationFilepath, true);


            //string filepath = "C:\\Users\\praja\\OneDrive\\Desktop\\FilesExample\\firstFile.txt";





            string filepath1 = "C:\\Users\\praja\\OneDrive\\Desktop\\FilesExample\\secondFile.txt";
            DateTime dt=File.GetCreationTime(filepath1);
            Console.WriteLine(dt);




        }
    }
}
