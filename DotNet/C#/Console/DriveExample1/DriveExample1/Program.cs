using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DriveExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] obj = DriveInfo.GetDrives();

            foreach (var files in obj)
            {
                Console.WriteLine(files);
            }

            //string [] filesEntry = Directory.GetFileSystemEntries("C:\\Aniruddha\\CppLecture\\");

            //foreach (var item in filesEntry)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(Directory.GetDirectories(obj[0].ToString()).Count());

            foreach (var item in obj)
            {
                string[] folderDetails = Directory.GetDirectories(item.ToString());
                foreach (var item1 in folderDetails)
                {
                    Console.WriteLine(item1);
                }
            }
        }
    }
}
