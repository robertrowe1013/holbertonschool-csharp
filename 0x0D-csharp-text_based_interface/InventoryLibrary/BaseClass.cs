using System;

/// <summary> base class </summary> ///
public class BaseClass
{
    string id { get; set; }
    DateTime date_created { get; set; }
    DateTime date_updated { get; set; }

    public BaseClass()
    {
        this.id = id;
        this.date_created = DateTime.Now;
        this.date_updated = DateTime.Now;
    }
}