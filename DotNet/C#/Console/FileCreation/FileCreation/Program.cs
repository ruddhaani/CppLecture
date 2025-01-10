using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "E:\\KYC\\Aadhar2.txt";
            File.Create(filepath);



        }
    }
}
