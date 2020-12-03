using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> uncommon = new List<int>();
        for (int i = 0; i < list1.Count; i++)
        {
            if (list2.Contains(list1[i]))
            {
                continue;
            }
            else
            {
                uncommon.Add(list1[i]);
            }
        }
        for (int i = 0; i < list2.Count; i++)
        {
            if (list1.Contains(list2[i]))
            {
                continue;
            }
            else
            {
                uncommon.Add(list2[i]);
            }
        }
        uncommon.Sort();
        return uncommon;
    }
}
