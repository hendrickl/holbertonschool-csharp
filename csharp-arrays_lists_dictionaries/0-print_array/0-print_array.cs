using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] newArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            if (size == 0)
            {
                Console.WriteLine("");
            }
            else if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            else
            {
                newArray[i] = i;
                Console.Write($"{i} ");
            }
        }
        return newArray;
    }
}
