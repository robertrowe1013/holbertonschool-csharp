using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tens = 0;
            int ones = 1;
            while (tens < 9)
            {
                while (ones < 10)
                {
                    Console.Write("{0}{1}", tens, ones);
                    if ((tens == 8) && (ones == 9))
                    {
                        Console.Write("\n");
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                    ones++;
                }
                tens++;
                ones = tens + 1;
            }
        }
    }
}
