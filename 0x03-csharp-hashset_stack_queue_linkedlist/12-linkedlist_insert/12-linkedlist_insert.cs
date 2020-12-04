using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        var node = myLList.First;
        if ((myLList.Count == 0) || (n < node.Value))
        {
            myLList.AddFirst(n);
            return node;
        }
        while (node.Next != null)
        {
            if (n < node.Value)
            {
                myLList.AddBefore(node, n);
                return node.Previous;
            }
            node = node.Next;
        }
        myLList.AddLast(n);
        return myLList.Last;
    }
}
