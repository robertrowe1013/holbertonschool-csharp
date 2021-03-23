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
        }
        tail = addNode;
    }

    // count method
    public int Count()
    {
        while (head != null)
        {
            count++;
            head = head.next;
        }
        return (count);
    }
}
