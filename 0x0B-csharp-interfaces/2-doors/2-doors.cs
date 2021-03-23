using System;

/// <summary>
/// Task 1 interface
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

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }

    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }

    void Collect();
}

class Door : Base, IInteractive
{

    public Door(String name)
    {
        if (name == null)
        {
            this.name = "Door";
        }
        else
        {
            this.name = name;
        }
    }
    public void Interact()
    {
        Console.WriteLine("You try to open the " + name + ". It's locked.");
    }
}