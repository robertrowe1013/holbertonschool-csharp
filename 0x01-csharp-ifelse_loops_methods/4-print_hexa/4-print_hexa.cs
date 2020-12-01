using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 99; i++)
            {
                Console.WriteLine("{0} = 0x{0:X}", i);
            }
        }
    }
}
