using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManagement
{
    public static class FileOps
    {
        public static bool CheckFile(string filepath)
        {
            if (File.Exists(filepath)){
                return false;
            }

            return true;
        }

        public static void CreateFile(string path)
        {
            if (CheckFile(path))
            {
                File.Create(path);
                Console.WriteLine("File Created");
            }
            else
            {
                Console.WriteLine("File already exists!");
            }
        }

        public static void DeleteFile(string path)
        {
            if (!CheckFile(path))
            {
                File.Delete(path);
                Console.WriteLine("File deleted");
            }
            else
            {
                Console.WriteLine("File doesnt exist");
            }
        }
    }
}
