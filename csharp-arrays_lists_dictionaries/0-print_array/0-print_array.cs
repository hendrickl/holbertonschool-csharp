using System;

class Array
{
    public static int[] CreatePrint(int size)
    {

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] newArray = new int[size];

        if (size == 0)
        {
            Console.WriteLine("");
            return null;
        }

        for (int i = 0; i < size; i++)
        {
            newArray[i] = i;
            Console.Write($"{i} ");

            if (i == newArray.Length - 1)
            {
                Console.WriteLine("");
                break;
            }
        }
        return newArray;
    }
}
