using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Security;

namespace FileWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath= "E:\\KYC\\Aadhar2.txt";
            string content = "I am Prajakta";
            //File.WriteAllText(filepath, content);

            //string output=File.ReadAllText(filepath);
            //Console.WriteLine(output);

            string sourcePath = "E:\\KYC\\Test.txt";
            //string destinationPath = "E:\\KYC\\Aadhar.txt";
            //  File.Copy(sourcePath, destinationPath,false);
           

            //DateTime dt=File.GetCreationTime(destinationPath);
            //Console.WriteLine(dt);

            //File.Delete(destinationPath);




        }
    }
}
