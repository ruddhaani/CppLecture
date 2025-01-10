using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    public class AccountInformation  //base class
    {
        public AccountInformation() 
        {
            Console.WriteLine("Account Information class");
        }
        public string AccountNo {  get; set; }
        public string Password { get; set; }



    }
}
