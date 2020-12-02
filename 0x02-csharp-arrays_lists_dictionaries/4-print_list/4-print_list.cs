using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> printList = new List<int>();
        int i;
        if (size == 0)
        {
            Console.Write("\n");
        }
        for (i = 0; i < size; i++)
        {
            printList.Add(i);
            Console.Write(i);
            if (i == (size - 1))
            {
                Console.Write("\n");
            }
            else
            {
                Console.Write(" ");
            }
        }

        return printList;
    }
}
