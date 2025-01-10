using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionOfCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character;
            int i;
            Console.WriteLine("Enter character");
            character=Convert.ToChar(Console.ReadLine());

            i=(int)character;
            if(character>=65 &&  character<=90)
            {
                Console.WriteLine("Character is "+char.ToLower(character));
            }
            else
            {
                Console.WriteLine("Character is " + char.ToUpper(character));
            }
            
            
        }
    }
}
