using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);

        List<int> commonSortedElements = new List<int>();

        foreach (int element in set1)
        {
            if (set2.Contains(element))
            {
                commonSortedElements.Add(element);
            }
        }

        return commonSortedElements;
    }
}
