using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("D:\\DirectoryPractice");

            Directory.CreateDirectory("D:\\DirectoryPractice\\Aniruddha");
            Directory.CreateDirectory("D:\\DirectoryPractice\\Sejal");
            Directory.CreateDirectory("D:\\DirectoryPractice\\Snehal");

            Console.WriteLine(Directory.GetCreationTime("D:\\DirectoryPractice\\Aniruddha"));
            Console.WriteLine(Directory.GetCurrentDirectory());

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (var item in drives)
            {
                string[] directoryDetails = Directory.GetDirectories(item.ToString());

                foreach (var item1 in directoryDetails)
                {
                    Console.WriteLine(item1);
                }
            }
        } 
    }
}
