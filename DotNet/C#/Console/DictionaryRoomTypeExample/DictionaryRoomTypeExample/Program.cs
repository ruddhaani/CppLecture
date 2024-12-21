using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryRoomTypeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> roomTypeObj = new Dictionary<int, string>();

            roomTypeObj.Add(1,"1BHK");
            roomTypeObj.Add(2, "2BHK");
            roomTypeObj.Add(3, "3BHK");
            roomTypeObj.Add(4, "4BHK");


            if(roomTypeObj.Count > 0)
            {
                foreach(var items in roomTypeObj)
                {
                    Console.WriteLine(items.Key + " : " + items.Value);
                }
            }

        }
    }
}
