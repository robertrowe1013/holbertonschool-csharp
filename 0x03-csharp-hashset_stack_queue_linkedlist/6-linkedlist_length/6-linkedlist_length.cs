using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int listCount = 0;
        foreach(int i in myLList)
        {
            listCount++;
        }
        return listCount;
    }
}
