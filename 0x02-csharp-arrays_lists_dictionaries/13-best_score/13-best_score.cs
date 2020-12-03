using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int max = -1;
        string name = "None";
        foreach (KeyValuePair<string, int> i in myList)
        {
            if (i.Value > max)
            {
                max = i.Value;
                name = i.Key;
            }
        }
        return name;
    }
}
