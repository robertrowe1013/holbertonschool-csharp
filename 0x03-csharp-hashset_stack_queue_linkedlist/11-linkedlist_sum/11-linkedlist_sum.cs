using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;
        var node = myLList.First;
        for (int i = 0; i < myLList.Count; i++)
        {
            sum += node.Value;
            node = node.Next;
        }
        return sum;
    }
}
