using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();
        foreach (string i in myDict.Keys)
        {
            newDict.Add(i, (myDict[i] * 2));
        }
        return newDict;
    }
}
