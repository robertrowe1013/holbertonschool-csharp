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
        return (String.Format("{0} is a {1}", name, this.GetType()));
    }
}
