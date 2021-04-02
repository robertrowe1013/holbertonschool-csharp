using System;

/// <summary> item class </summary> ///
public class Item : BaseClass
{
    string name { get; set; }
    string description { get; set; }
    float price { get; set; }
    List<string> tags { get; set; }
}