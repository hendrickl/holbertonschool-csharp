using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string biggestIntKey = "";
        int biggestIntValue = 0;

        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > biggestIntValue)
            {
                biggestIntKey = entry.Key;
                biggestIntValue = entry.Value;
            }
            else if (entry.Value == biggestIntValue)
            {
                biggestIntKey = "None";
            }
        }

        return biggestIntKey;
    }
}
