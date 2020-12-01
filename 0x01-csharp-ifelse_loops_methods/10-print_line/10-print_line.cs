using System;

class Line
{
    public static void PrintLine(int length)
    {
        int i;
        for (i = 0; i < length; i++)
        {
            Console.Write("_");
        }
        Console.Write("\n");
    }
}
