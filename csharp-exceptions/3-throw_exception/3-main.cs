using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Except.Throw();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}