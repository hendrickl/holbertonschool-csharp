using System;

class Int
{
    public static void divide(int a, int b)
    {
        int result = 0;

        try
        {
            result = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
            Console.WriteLine("{0} / 0 = 0", a);
        }
        finally
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
    }
}
