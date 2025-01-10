
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_details;

namespace bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardDetails obj = new CardDetails(); 
            //here error is because its class is internal 
            
            RoomServices roomServicesobj = new RoomServices();
            Console.WriteLine(roomServicesobj.Services());
            Console.WriteLine(roomServicesobj.PaintingService());
            Console.ReadLine();
        }
    }
}
