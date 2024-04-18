using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] my2DArray = new int[5, 5];
        my2DArray[2, 2] = 1;

        for (int i = 0; i < my2DArray.GetLength(0); i++)
        {
            for (int j = 0; j < my2DArray.GetLength(1); j++)
            {
                Console.Write(my2DArray[i, j] + " ");
            }
            Console.WriteLine("");
        }
    }
}
