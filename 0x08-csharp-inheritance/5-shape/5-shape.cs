using System;

class Shape
{
    /// <summary>
    /// Shape Area
    /// </summary>
    public virtual int Area()
    {
        string msg = "Area() is not implemented";
        throw new NotImplementedException(msg);
    }
}
