using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else if (size == 0)
        {
            int[] newArray = new int[0];
            Console.Write("\n");
            return newArray;
        }
        else
        {
            int[] newArray = new int[size];
            int i;
            for (i = 0; i < size; i++)
            {
                newArray[i] = i;
            }
            return newArray;
        }
    }
}
