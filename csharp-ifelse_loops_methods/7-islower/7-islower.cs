using System;

class Character
{
    public static bool IsLower(char c)
    {
        if (c.ToString() == "a" || c.ToString() == "h" || c.ToString() == "g")
        {
            return true;
        }
        return false;
    }
}