using System;

namespace InventoryLibrary
{
    public class BaseClass
    {
        string id { get; set; }
        DateTime date_created { get; set; }
        DateTime date_updated { get; set; }
    }

    public class Item : BaseClass
    {
        string name { get; set; }
        string description { get; set; }
        float price { get; set; }
        List tags = new List<string>();
    }

    public class User : BaseClass
    {
        string name { get; set; }
    }

    public class Inventory : BaseClass
    {
        id user_id;
        id item_id;
        int quantity = 1;
    }
}

