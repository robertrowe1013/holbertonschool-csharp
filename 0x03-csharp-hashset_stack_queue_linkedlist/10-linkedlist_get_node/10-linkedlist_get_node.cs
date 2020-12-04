using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n >= myLList.Count)
        {
            return 0;
        }
        int val = 0;
        var node =myLList.First;
        for (int i = 0; i <= n; i++)
        {
            val = node.Value;
            node = node.Next;
        }
        return val;
    }
}
