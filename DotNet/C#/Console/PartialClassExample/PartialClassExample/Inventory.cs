using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
    internal class Inventory
    {
        public Inventory() { 
        
            UserModel obj = new UserModel();
            obj.GetEmployee();
            obj.GetPayroll();

        }
    }

    public partial class UserModel
    {
        public void GetPayroll()
        {
            Console.WriteLine("12324");
        }
    }
}
