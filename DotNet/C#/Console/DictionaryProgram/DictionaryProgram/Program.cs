using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //same for dictionary syntax 
            SortedList<int, string> roomObj = new SortedList<int, string>();
            roomObj.Add(3, "1BHK");
            roomObj.Add(4, "2BHK");  //key should be unique. either error will be An item with the
                                     //same key has already been added.'

            roomObj.Add(2, "4BHK");
            roomObj.Add(1, "5BHK");

            Console.WriteLine("Reading element from sortedlist");
            if (roomObj.Count > 0)  //or used Length also here
            {
                foreach (var room in roomObj)
                {
                    Console.WriteLine("room key is "+room.Key+" "+"room name is "+room.Value);
                }
                Console.ReadLine();
                Console.WriteLine("count is "+roomObj.Count);
            }

        }
    }
}
