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

class Rectangle : Shape
{
    /// <summary>
    /// retangle shape
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
    public new int Area()
    {
        return (height * width);
    }
    public override string ToString()
    {
        string str = "[Rectangle] " + width + " / " + height;
        return (str);    
    }
}
