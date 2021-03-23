using System;

/// <summary>
/// Task 0, abstract class
/// </summary>
abstract class Base
{
    public string name;

    // ToString override
    public override string ToString()
    {
        return (name + " is a " + this.GetType());
    }
}
