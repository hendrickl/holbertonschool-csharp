using System;
using System.Co­lle­cti­ons.Ge­neric;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");

        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }

        Console.WriteLine($"Top item: {aStack.Peek()}");

        if (aStack.Contains(search))
        {
            Console.WriteLine($"Stack contains \"{search}\": True");
        }
        else
        {
            Console.WriteLine($"Stack contains \"{search}\": False");
        }

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

        aStack.Push(newItem);
        return aStack;
    }
}