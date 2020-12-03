using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        Dictionary<string, string>.KeyCollection keyList = myDict.Keys;
        int counter = 0;
        foreach(string s in keyList)
        {
            counter++;
        }
        return counter;
    }
}
