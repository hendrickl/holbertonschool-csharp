using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        string printedLine = "\\";

        if (length <= 0)
        {
            Console.WriteLine("");
        }

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(printedLine);
            Console.Write(new string(' ', i + 1));
        }
    }
}
