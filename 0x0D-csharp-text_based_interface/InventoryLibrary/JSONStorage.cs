using System;
using System.Text.Json;

public class JSONStorage
{
    Dictionary<string, BaseClass> objects;
    Dictionary<string, BaseClass> All()
    {
        return (objects);
    }

    void New(BaseClass obj)
    {
        string key;
        key = String.Format("{0}.{1}", obj.GetType(), obj.id);
        this.objects.Add(key, obj);
    }

    void Save()
    {
        File.WriteAllText("storage/inventory_manager.json", JsonSerializer.Serialize(objects));
    }
    void Load()
    {
        objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(File.ReadAllText("storage/inventory_manager.json"));
    }
}