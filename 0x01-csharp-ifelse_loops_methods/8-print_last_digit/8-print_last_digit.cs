using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int last = Math.Abs(number % 10);
        Console.Write(last);
        return last;
    }
}
