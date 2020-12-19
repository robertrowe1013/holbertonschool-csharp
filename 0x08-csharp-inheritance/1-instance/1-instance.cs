using System;
using System.Collections.Generic;

class Obj
{
    /// <summary>
    /// check obj inheritance
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
        {
            return (true);
        }
        return (false);
    }
}
