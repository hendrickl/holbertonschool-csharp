using System;

class Program
{
    static void Main(string[] args)
    {
        string fizz = "Fizz";
        string buzz = "Buzz";
        string fizzBuzz = "FizzBuzz";

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write(fizzBuzz + " ");
            }
            else if (i % 5 == 0)
            {
                Console.Write(buzz + " ");
            }
            else if (i % 3 == 0)
            {
                Console.Write(fizz + " ");
            }
            else
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine("");
    }
}