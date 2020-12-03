using System;
using System.Collections.Generic;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            int row;
            int col;

            for (row = 0; row < 5; row++)
            {
                for (col = 0; col < 5; col++)
                {
                    if ((row == 2) && (col == 2))
                    {
                        matrix[row, col] = 1;
                        Console.Write("1");
                    }
                    else
                    {
                        matrix[row, col] = 0;
                        Console.Write("0");
                    }
                    if (col == 4)
                    {
                        Console.Write("\n");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}
