using System;

/// <summary>
/// Shape
/// </summary>
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

/// <summary>
/// Rectangle
/// </summary>
class Rectangle : Shape
{
    /// <summary>
    /// width
    /// </summary>
    private int width;
    public int Width
    {
        get
        {
            return (width);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }
    /// <summary>
    /// height
    /// </summary>
    private int height;
    public int Height
    {
        get
        {
            return (height);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }
    /// <summary>
    /// area
    /// </summary>
    public new int Area()
    {
        return (height * width);
    }
    /// <summary>
    /// string override
    /// </summary>
    public override string ToString()
    {
        string str = "[Rectangle] " + width + " / " + height;
        return (str);
    }
}
