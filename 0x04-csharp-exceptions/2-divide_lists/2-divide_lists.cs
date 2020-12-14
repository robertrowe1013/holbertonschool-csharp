using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> prodList = new List<int>();
        int prod = 0;
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                prod = list1[i] / list2[i];
                prodList.Add(prod);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                prodList.Add(prod);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            prod = 0;
        }
        return (prodList);
    }
}
