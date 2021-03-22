using System;

/// <summary>
/// Generic Queue Class
/// </summary>
class Queue<T>
{
    // check type
    public Type CheckType()
    {
        return (typeof(T));
    }
}
