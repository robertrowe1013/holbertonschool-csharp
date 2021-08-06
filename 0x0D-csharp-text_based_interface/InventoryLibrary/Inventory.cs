using System;

/// <summary> inventory class </summary> ///
public class Inventory : BaseClass
{
    public string user_id;
    public string item_id;
    public int quantity = 1;

    public Inventory(string user_id, string item_id, int quantity)
    {
        this.user_id = user_id;
        this.item_id = item_id;
        if (quantity < 0)
        {
            this.quantity = 1;
        }
        else
        {
            this.quantity = quantity;
        }
    }
}