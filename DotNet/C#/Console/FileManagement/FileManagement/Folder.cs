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
        public static bool checkExist(string folderpath)
        {
            if (Directory.Exists(folderpath))
            {
                return true;
            }
            return false;
        }

        public static void createFolder(string folderpath)
        {
            if (!checkExist(folderpath))
            {
                Directory.CreateDirectory(folderpath);
            }
        }

        public static void deleteFolder(string folderpath)
        {
            if (checkExist(folderpath))
            {
                Directory.Delete(folderpath);
            }
        }
    }
}
