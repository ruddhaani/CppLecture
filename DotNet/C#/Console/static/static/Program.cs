using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Static;

namespace @static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----static class-----");
            Log.Debug("Start GetEmployee function");
            Console.WriteLine("Employee name " + Employee.GetEmployee());
            Log.Debug("End GetEmployee function");

            Log.Debug("Start PayroleDetails function");
            Console.WriteLine("Employe salary " + Employee.GetPayRoleDetails());
            Log.Debug("End PayroleDetails functions");

            Console.WriteLine(Manager.message());

            Console.ReadLine();


        }
    }
}
