using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newList = new LinkedList<int>();
        if (size > -1)
        {
            for (int i = 0; i < size; i++)
            {
                newList.AddLast(i);
                Console.WriteLine(i);
            }
        }
        return newList;
    }
}
