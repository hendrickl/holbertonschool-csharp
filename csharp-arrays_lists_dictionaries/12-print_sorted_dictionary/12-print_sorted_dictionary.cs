using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        string[] keys = new string[myDict.Count];
        myDict.Keys.CopyTo(keys, 0);
        Array.Sort(keys);

        foreach (string key in keys)
            Console.WriteLine($"{key}: {myDict[key]}");
    }
}
