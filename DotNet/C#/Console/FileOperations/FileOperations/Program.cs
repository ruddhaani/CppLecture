using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManagement;

namespace FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "E:\\KYC4";

            Folder.createFolder(filepath);
            Folder.deleteFolder(filepath);
           
        }
    }
}
