using System;

namespace DiamondCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows for the diamond: ");
            int maxLength = Convert.ToInt32(Console.ReadLine());

            char ast = '*';
            char space = ' ';

            // Upper half of the diamond
            for (int i = 1; i <= maxLength; i += 2)
            {
                for (int j = 0; j < (maxLength - i) / 2; j++)
                {
                    Console.Write(space);
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write(ast);
                }
                Console.WriteLine();
            }

            // Lower half of the diamond
            for (int i = maxLength - 2; i >= 1; i -= 2)
            {
                for (int j = 0; j < (maxLength - i) / 2; j++)
                {
                    Console.Write(space);
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write(ast);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
