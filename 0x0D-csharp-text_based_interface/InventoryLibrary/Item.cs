using System;
using System.Collections;
using System.Collections.Generic;

/// <summary> item class </summary> ///
public class Item : BaseClass
{
    public string name { get; set; }
    public string description { get; set; }
    public float price { get; set; }
    public List<string> tags { get; set; }

    public Item(string name, string description=null, float price=0, List<string> tags=null)
    {
        this.name = name;
        this.description = description;
        this.price = price;
        this.tags = tags;
    }
}