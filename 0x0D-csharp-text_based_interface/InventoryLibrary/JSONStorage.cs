using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public class JSONStorage
{
    public Dictionary<string, BaseClass> objects;
    public Dictionary<string, BaseClass> All()
    {
        return (objects);
    }

    public void New(BaseClass obj)
    {
        string key;
        key = String.Format("{0}.{1}", obj.GetType(), obj.id);
        this.objects.Add(key, obj);
    }

    public void Save()
    {
        File.WriteAllText("storage/inventory_manager.json", JsonSerializer.Serialize(objects));
    }
    public void Load()
    {
        objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(File.ReadAllText("storage/inventory_manager.json"));
    }
}