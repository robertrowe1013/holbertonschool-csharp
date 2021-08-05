using System;

/// <summary> user class </summary> ///
public class User : BaseClass
{
    string name { get; set; }

    public User(string name)
    {
        this.name = name;
    }
}