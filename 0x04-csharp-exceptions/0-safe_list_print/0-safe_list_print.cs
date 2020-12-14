using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            try
            {
                Console.WriteLine(myList[i]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return (count);
            }
            count++;
        }
        return (count);
    }
}
