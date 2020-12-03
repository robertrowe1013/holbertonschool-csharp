using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> hashSet = new HashSet<int>();
        for (int i = 0; i < myList.Count; i++)
        {
            hashSet.Add(myList[i]);
        }
        int sum = 0;
        foreach (int i in hashSet)
        {
            sum += i;
        }
        return sum;
    }
}
