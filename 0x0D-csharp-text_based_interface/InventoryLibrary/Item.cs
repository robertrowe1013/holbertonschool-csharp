using System;

/// <summary> item class </summary> ///
public class Item : BaseClass
{
    string name { get; set; }
    string description { get; set; }
    float price { get; set; }
    List<string> tags { get; set; }

    public Item(string name, string description=null, float price=0, List<string> tags=null)
    {
        this.name = name;
        this.description = description;
        this.price = price;
        this.tags = tags;
    }
}