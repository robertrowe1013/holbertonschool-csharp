using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int counter = 0;
        foreach (int i in myLList)
        {
            if (i == value)
            {
                break;
            }
            counter++;
        }
        if (counter == myLList.Count)
        {
            return (-1);
        }
        return (counter);
    }
}
