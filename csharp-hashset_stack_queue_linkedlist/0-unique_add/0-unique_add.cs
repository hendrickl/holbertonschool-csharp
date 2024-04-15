using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> uniqueIntegers = new HashSet<int>();
        int sum = 0;

        foreach (int number in myList)
        {
            if (uniqueIntegers.Add(number))
            {
                sum += number;
            }
        }

        return sum;
    }
}
