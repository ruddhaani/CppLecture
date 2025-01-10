using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NoofFilesInFolder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderpath = "E:\\KYC2";

            Directory.CreateDirectory(folderpath);

            string[] fileDetails=Directory.GetFiles(folderpath);
            Console.WriteLine("total files :" + fileDetails.Count());
            foreach (string file in fileDetails)
            {
                Console.WriteLine(file);
            }


            //Console.ReadLine();

            Console.WriteLine("Drive Example");
            //string driveName = "E:\\";
            DriveInfo[] obj=DriveInfo.GetDrives();

            
            foreach (var items in obj)
            {
                Console.WriteLine(items);
            }

            string folderpath1 = "E:\\KYC2\\AadharCard\\PersonInfo";
            Directory.CreateDirectory(folderpath1);

            string drivepath1 = "C:\\";
            string drivepath2 = "D:\\";
            string drivepath3 = "E:\\";
            string[] folderDetails1 = Directory.GetDirectories(drivepath1);
            string[] folderDetails2 = Directory.GetDirectories(drivepath2);
            string[] folderDetails3 = Directory.GetDirectories(drivepath3);
            foreach (var folder1 in folderDetails1)
            {
                Console.WriteLine(folder1);

                foreach (var folder2 in folderDetails2)
                {
                    Console.WriteLine(folder2);
                    foreach (var folder3 in folderDetails3)
                    {
                        Console.WriteLine(folder3);
                    }
                }
            }

            //we can write in other way
            Console.WriteLine("Drives are");
            DriveInfo[] obj1 = DriveInfo.GetDrives();

            foreach (object items in obj1)
            {
                string[] folders = Directory.GetDirectories(items.ToString());
                {
                    Console.WriteLine($"{folders}");
                }
                Console.WriteLine(items);
            }
            //string folderDetails = Directory.GetDirectories(folders);

                
        }





    }
    }

