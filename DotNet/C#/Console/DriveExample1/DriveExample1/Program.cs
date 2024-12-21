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
            string driveName = "D:\\";
            DriveInfo[] obj = DriveInfo.GetDrives();

            foreach (var files in obj)
            {
                Console.WriteLine(files);
            }

            Console.WriteLine(Directory.GetDirectories(obj[1].ToString()).Count());

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
