using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        string prompt = "Inventory Manager\n-------------------------\n<ClassNames> show all ClassNames of objects\n<All> show all objects\n<All [ClassName]> show all objects of a ClassName\n<Create [ClassName]> a new object\n<Show [ClassName object_id]> an object\n<Update [ClassName object_id]> an object\n<Delete [ClassName object_id]> an object\n<Exit>\n";
        JSONStorage storage = new JSONStorage();
        storage.Load();
        Console.Write(prompt);
    }
}