﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logger
{
    public static class Logs
    {
        public static bool CheckFile(string filepath)
        {
            DateTime dateTime = DateTime.Now;
            
            if(File.Exists(filepath) || File.GetCreationTime(filepath).Date == dateTime.Date)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void Info(string message , string filepath)
        {
            DateTime dateTime = DateTime.Now;
            string entireMsg = dateTime + Environment.NewLine + "Info:" + Environment.NewLine + Environment.NewLine + message + Environment.NewLine + Environment.NewLine;
            filepath = filepath + "logs" + "_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";

            if (CheckFile(filepath))
            {
                //File.Create(filepath);

                //below using code was referenced from stackoverflow
                using (File.Create(filepath)) { }
                File.AppendAllText(filepath, entireMsg);
            }
            else
            {
                File.AppendAllText(filepath, entireMsg);
            }
        }

        public static void Debug(string message, string filepath)
        {
            DateTime dateTime = DateTime.Now;
            string entireMsg = dateTime + Environment.NewLine + "Debug:" + Environment.NewLine + Environment.NewLine + message + Environment.NewLine + Environment.NewLine;
            //filepath = filepath + Convert.ToString(dateTime);
            filepath = filepath + "logs" + "_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";

            if (CheckFile(filepath))
            {
                //File.Create(filepath);
                using (File.Create(filepath)) { }
                File.AppendAllText(filepath, entireMsg);
            }
            else
            {
                File.AppendAllText(filepath, entireMsg);
            }
        }

        public static void Error(string message, string filepath)
        {
            DateTime dateTime = DateTime.Now;
            string entireMsg = dateTime + Environment.NewLine + "Error:" + Environment.NewLine + Environment.NewLine + message + Environment.NewLine + Environment.NewLine;
            //filepath = filepath + Convert.ToString(dateTime);
            filepath = filepath + "logs" + "_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";

            if (CheckFile(filepath))
            { 
                //File.Create(filepath);
                using (File.Create(filepath)) { }
                File.AppendAllText(filepath, entireMsg);
            }
            else
            {
                File.AppendAllText(filepath, entireMsg);
            }
        }
    }
}
