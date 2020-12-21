using System;

/// <summary>
/// Base class for shapes
/// </summary>
class Shape
{
    /// <summary>
    /// Unimplemented area function
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Rectangle class, inherits from shape base class
/// </summary>
class Rectangle : Shape
{
    /// rectangle width
    private int width;

    /// rectangle height
    private int height;

    /// <summary>
    /// Width for use in getter/setter
    /// </summary>
    public int Width
    {
        get => width;
        set
        {
            if (value < 0) {
                throw new ArgumentException("Width must be greater than or equal to 0");
            } else {
                width = value;
            }
        }
    }
    
    /// <summary>
    /// Height for use in getter/setter
    /// </summary>
    public int Height
    {
        get => height;
        set
        {
            if (value < 0) {
                throw new ArgumentException("Height must be greater than or equal to 0");
            } else {
                height = value;
            }
        }
    }

    /// <summary>
    /// Override for area implementation
    /// </summary>
    public new int Area()
    {
        return (width * height);
    }
    /// <summary>
    /// Override for ToString method
    /// </summary>
    public override string ToString()
    {
        return String.Format("[{0}] {1} / {2}", this.GetType().Name, this.width, this.height);
    }
}
