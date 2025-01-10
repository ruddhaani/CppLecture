using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CrosinRequest request = new CrosinRequest();
            request.Pricelevel=PriceLevelConstant.PriceLevel;

            if(PriceLevel.Listed.ToString().ToLower()==request.Pricelevel.ToLower())
            {
                Console.WriteLine("This medicine process for sell");
            }
        }
    }
}
