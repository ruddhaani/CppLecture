using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClass;

namespace BankDetailsMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardDetails cardDetails = new CardDetails();

            Console.WriteLine(cardDetails.GetATMPin());

            Console.WriteLine(cardDetails.Balance());


        }
    }
}
