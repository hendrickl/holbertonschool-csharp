using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> lList = new LinkedList<int>();

        if (size < 0)
        {
            return lList;
        }

        for (int i = 0; i < size; i++)
        {
            lList.AddLast(i);
            Console.WriteLine(i);
        }

        return lList;
    }
}
