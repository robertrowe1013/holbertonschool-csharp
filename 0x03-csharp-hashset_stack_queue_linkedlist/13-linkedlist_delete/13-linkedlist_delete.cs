﻿using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if ((index >= myLList.Count) || (myLList.Count == 0) || (index < 0))
        {
            ;
        }
        else if (index == 0)
        {
            myLList.RemoveFirst();
        }
        else if (index == (myLList.Count - 1))
        {
            myLList.RemoveLast();
        }
        else
        {
            var node = myLList.First;
            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }
            myLList.Remove(node);
        }
    }
}
