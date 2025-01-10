using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class Log
    {
        public static string GetFilePath(string baseFilePath)
        {
            return baseFilePath + "logs_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
        }   
        public static void WriteLog(string messageType, string message, string filepath)
        {
            string fullMessage = DateTime.Now.ToString() + Environment.NewLine + messageType + ":" + Environment.NewLine + message + Environment.NewLine
                + Environment.NewLine;

            string logFilePath = GetFilePath(filepath);

            if (!File.Exists(logFilePath)) {
             using   (File.Create(logFilePath))   { }
            }

            File.AppendAllText(logFilePath, fullMessage);
        }

        public static void Info(string message, string filepath)
        {
            WriteLog("Info",message, filepath);
        }
        public static void Debug(string message, string filepath)
        {
            WriteLog("Debug",message, filepath);
        }

        public static void Error(string message, string filepath)
        {
            WriteLog("Error",message, filepath);
        }
        
    }
}
