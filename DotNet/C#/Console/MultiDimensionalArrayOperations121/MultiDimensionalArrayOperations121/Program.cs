using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrayOperations121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 2];

            for(int i = 0; i< array.GetLength(0); i++)
            {
                for(int j =0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            for (int i = 0; i < array.GetLength(0); i++) // Outer loop for rows
            {
                for (int j = 0; j < array.GetLength(1); j++) // Inner loop for columns
                {
                    Console.Write(array[i, j] + " "); // Print the value
                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }
    }
}
