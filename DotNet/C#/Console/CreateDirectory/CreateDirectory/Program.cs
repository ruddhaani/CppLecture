using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using FileManagement;

namespace CreateDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderpath = "E:\\KYCFolder";
            Folder.createFolder(folderpath);
            Console.WriteLine("Folder is created");


            Folder.deleteFolder(folderpath);
            Console.WriteLine("Folder deleted");



















            //string folderpath = "E:\\KYC";
            //Folder.createFolder(folderpath);

            //Folder.deleteFolder(folderpath);
            //Console.WriteLine("Folder is deleted");




















            //Directory.CreateDirectory(folderpath);
            //Console.WriteLine("folder created");


            //string folderpath = "E:\\KYC";
            //if (Directory.Exists(folderpath))
            //{
            //    Directory.Delete("E:\\KYC");
            //    Console.WriteLine("Folder Deleted");
            //}

            //string filepath = "E:\\KYC";
            //DateTime dt=Directory.GetCreationTime(filepath);
            //Console.WriteLine(dt);



        }
    }
}
