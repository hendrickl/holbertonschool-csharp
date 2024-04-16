using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print the number of items in aQueue
        // Format: Number of items: <number>

        Console.WriteLine($"Number of items: {aQueue.Count}");

        // Print the item at the top of aQueue without removing it
        // Format: First item: <item>
        // If aQueue is empty, print Queue is empty

        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }

        // Add a new given item newItem to aQueue

        aQueue.Enqueue(newItem);

        // Print if aQueue contains a given item search
        // Format: Queue contains <search>: <True / False>

        if (aQueue.Contains(search))
        {
            Console.WriteLine($"Queue contains \"{search}\": True");
        }
        else
        {
            Console.WriteLine($"Queue contains \"{search}\": False");
        }

        // If aQueue contains the given item search, remove all items up to and including search; otherwise, leave aQueue as is
        // You can use .Dequeue() only once

        if (aQueue.Contains(search))
        {
            while (aQueue.Contains(search))
            {
                aQueue.Dequeue();
            }
        }

        return aQueue;
    }
}
