using System;

/// <summary>
/// Generic Queue Class
/// </summary>
class Queue<T>
{
    public Node head;
    public Node tail;
    public int count;

    // check type
    public Type CheckType()
    {
        return (typeof(T));
    }
    // Node class
    public class Node
    {
        public T value;
        public Node next = null;

        public Node(T value)
        {
            this.value = value;
        }
    }

    // Enqueue method
    public void Enqueue(T value)
    {
        Node addNode = new Node(value);

        if (head == null)
        {
            head = addNode;
            tail = head;
        }
        else
        {
            tail.next = addNode;
            tail = tail.next;
        }
        count++;
    }

    // count method
    public int Count()
    {
        return (count);
    }

    // dequeue method
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        T value = head.value;
        head = head.next;
        count--;
        return (value);
    }

    // peek method
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return (head.value);
    }

    // print method
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.value);
            temp = temp.next;
        }
    }

    // concatenate method
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (null);
        }
        if (typeof(T) == typeof(string) || typeof(T) == typeof(char))
        {
            string constr = "";
            Node temp = head;
            while (temp != null)
            {
                constr += temp.value;
                temp = temp.next;
            }
            return (constr);
        }
        Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
        return (null);
    }
}
