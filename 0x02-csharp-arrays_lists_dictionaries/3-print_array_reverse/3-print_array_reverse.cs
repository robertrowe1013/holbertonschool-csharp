using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if ((array == null) || (array.Length == 0))
        {
            Console.Write("\n");
        }
        else
        {
            int i = (array.Length - 1);
            while (i >= 0)
            {
                Console.Write("{0}", array[i]);
                if (i == 0)
                {
                    Console.Write("\n");
                }
                else
                {
                    Console.Write(" ");
                }
                i--;
            }
        }

    }
}
