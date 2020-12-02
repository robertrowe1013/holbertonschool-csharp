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
        if (size == 0)
        {
            int[] emptyArray = new int[0];
            Console.Write("\n");
            return emptyArray;
        }
        int[] newArray = new int[size];
        int i;
        for (i = 0; i < size; i++)
        {
            newArray[i] = i;
            Console.Write(i);
            if (i == (size -1))
            {
                Console.Write("\n");
            }
            else
            {
                Console.Write(" ");
            }
        }
        return newArray;
    }
}
