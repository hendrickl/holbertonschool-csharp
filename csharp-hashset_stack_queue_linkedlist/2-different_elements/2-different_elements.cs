﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set = new HashSet<int>(list1);
        set.SymmetricExceptWith(list2);
        return new List<int>(set);
    }
}
