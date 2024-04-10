using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                Console.Write(i);

                if (j == 9 && i == 8)
                {
                    Console.WriteLine(j);
                    break;
                }

                Console.Write(j + ", ");
            }
        }
    }
}
