using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 97; i < 123; i++)
            {
                if ((i != 101) && (i != 113))
                {
                    Console.Write("{0}", (char)i);
                }
            }
        }
    }
}
