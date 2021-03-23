using System;

/// <summary>
/// Task 0, abstract class
/// </summary>
abstract class Base
{
    public string name = null;

    public override string ToString()
    {
        return (name + " is a " + this.GetType());
    }
}
