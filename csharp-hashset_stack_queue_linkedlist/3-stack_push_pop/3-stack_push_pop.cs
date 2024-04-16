using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print the number of items in aStack
        // Format: Number of items: <number>

        Console.WriteLine($"Number of items: {aStack.Count}");

        // Print the item at the top of aStack without removing it
        // Format: Top item: <item>
        // If aStack is empty, print Stack is empty

        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }

        // Print if aStack contains a given item search
        // Format: Stack contains <search>: <True / False>

        if (aStack.Contains(search))
        {
            Console.WriteLine($"Stack contains \"{search}\": True");
        }
        else
        {
            Console.WriteLine($"Stack contains \"{search}\": False");
        }

        // If aStack contains the given item search, remove all items up to and including search; otherwise, leave aStack as is

        if (aStack.Contains(search))
        {
            while (aStack.Contains(search))
            {
                aStack.Pop();
            }
        }
        else
        {
            return aStack;
        }

        // Add a new given item newItem to aStack

        aStack.Push(newItem);

        // Return aStack

        return aStack;
    }
}