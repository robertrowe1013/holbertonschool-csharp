using System;
using System.Collections.Generic;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] newArray = new int[3][];
            newArray[0] = new int[] {0, 1, 2, 3};
            newArray[1] = new int[] {0, 1, 2, 3, 4, 5, 6};
            newArray[2] = new int[] {0, 1};
            Console.WriteLine("0 1 2 3");
            Console.WriteLine("0 1 2 3 4 5 6");
            Console.WriteLine("0 1");
        }
    }
}