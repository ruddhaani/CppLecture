using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement
{
    public static class Folder
    {
        public static bool CheckFolder(string path)
        {
            if (Directory.Exists(path))
            {
                return false;
            }

            return true;
        }

        public static void CreateFolder(string path)
        {
            if (CheckFolder(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Folder Created");
            }
            else
            {
                Console.WriteLine("Folder already exists!");
            }
        }

        public static void DeleteFolder(string path)
        {
            if (!CheckFolder(path))
            {
                Directory.Delete(path);
            }
            else
            {
                Console.WriteLine("Folder doesnt exist");
            }
        }
    }
}
