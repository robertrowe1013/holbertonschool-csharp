using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
        {
            int i = 0;
            int spaces;
            while (i < length)
            {
                for (spaces = 0; spaces < i; spaces++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\\n");
                i++;
            }
            Console.WriteLine("\n");
        }
        Console.Write("\n");
    }
}
