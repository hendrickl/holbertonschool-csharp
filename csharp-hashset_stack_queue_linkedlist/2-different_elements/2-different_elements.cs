using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> differentSortedElements = new List<int>();

        for (int i = 0; i <= 8; i++)
        {
            differentSortedElements.Add(i);

            if (list1.Contains(i) && list2.Contains(i))
            {
                differentSortedElements.Remove(i);
            }
        }

        return differentSortedElements;
    }
}
