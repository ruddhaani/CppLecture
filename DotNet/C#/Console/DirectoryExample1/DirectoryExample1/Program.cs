using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManagement;

namespace DirectoryExample1
{
    internal class Program
    {

        public static bool CheckDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                return false;
            }

            return true;
        }
        
        static void Main(string[] args)
        {
            string basePath = "D:\\DirectoryPracticalC#";

            string directoryCreate = basePath + "\\Example1";

            string kycFolderPath = directoryCreate + "\\KYC";

            Folder.CreateFolder(directoryCreate);
            Folder.CreateFolder(kycFolderPath);

            FileOps.CreateFile(basePath + "\\Example1\\KYC\\Pan.txt");
            FileOps.CreateFile(basePath + "\\Example1\\KYC\\Adhaar.txt");

            Folder.CreateFolder(kycFolderPath + "\\xyz");
            //Folder.DeleteFolder(kycFolderPath + "\\xyz");
        }

    }
}
