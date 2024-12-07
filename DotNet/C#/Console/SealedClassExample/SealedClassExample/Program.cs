using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountInformation accountInformation = new AccountInformation();
            accountInformation.AccountNumber = 1234;
            Console.WriteLine(accountInformation.AccountNumber);

            Console.WriteLine();
            Employee employeeObj = new Employee();
        }
    }
}
