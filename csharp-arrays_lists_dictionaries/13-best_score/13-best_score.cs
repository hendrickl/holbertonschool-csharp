using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string biggestIntKey = "";
        int biggestIntValue = -1;

        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > biggestIntValue)
            {
                biggestIntKey = entry.Key;
                biggestIntValue = entry.Value;
            }
        }

        if (biggestIntValue == -1)
        {
            return "None";
        }
        return biggestIntKey;
    }
}
