using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClass
{
    public class CardDetails
    {
        public int GetATMPin()
        {
            return 1234;
        }

        private int getBalance()
        {
            return 1000;
        }
        
        public int Balance()
        {
            return getBalance();
        }

    }
}
