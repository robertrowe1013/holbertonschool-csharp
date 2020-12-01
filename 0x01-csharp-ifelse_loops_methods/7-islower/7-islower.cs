using System;

class Character
{
    public static bool IsLower(char c)
    {
        if (((char)c > 96) && ((char)c < 123))
        {
            return true;
        }
        return false;
    }
}
