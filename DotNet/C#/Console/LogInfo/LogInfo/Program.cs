using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace LogInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "E:\\Logs";
            Log.Info("Info -- Project Started",filepath);
            try
            {
                Log.Debug("Debug--Main Function Start",filepath);

                Log.Debug("Debug--Main Function End", filepath);
            }
            catch(Exception ex) 
            {
                Log.Error("Error--Exception occured " + ex.Message, filepath);
            }
            finally
            {
                Log.Info("Info -- Project Ended", filepath);
            }
        }
    }
}
