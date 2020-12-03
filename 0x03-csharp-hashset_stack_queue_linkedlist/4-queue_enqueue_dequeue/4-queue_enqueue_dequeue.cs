using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);
        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }
        Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));
        while (aQueue.Contains(search))
        {
            string stop = aQueue.Dequeue();
            if (stop == search)
            {
                break;
            }
        }
        aQueue.Enqueue(newItem);
        return aQueue;
    }
}
