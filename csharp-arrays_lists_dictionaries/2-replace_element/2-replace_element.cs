using System;

class Array
{
    public static void ReplaceElement(int[] array, int index, int n)
    {
        if (index >= array.Length || index < 0)
        {
            Console.WriteLine("Index out of range");
            return;
        }
        array[index] = n;
    }
}
