﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastDigit = number % 10;
        string strLastDigit = "The last digit of";

        if (lastDigit > 5)
        {
            Console.WriteLine($"{strLastDigit} {number} is {lastDigit} and is greater than 5");
        }
        else if (lastDigit == 0)
        {
            Console.WriteLine($"{strLastDigit} {number} is {lastDigit} and is 0");
        }
        else if (lastDigit < 6 && lastDigit != 0)
        {
            Console.WriteLine($"{strLastDigit} {number} is {lastDigit} and is less than 6 and not 0");
        }
    }
}
