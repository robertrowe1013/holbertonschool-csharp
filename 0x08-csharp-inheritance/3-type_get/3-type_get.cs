using System;
using System.Collections.Generic;
using System.Reflection;

class Obj
{
    /// <summary>
    /// print properties and methods
    /// </summary>
    public static void Print(object myObj)
    {
        PropertyInfo[] props = myObj.GetType().GetProperties();
        MethodInfo[] methods = myObj.GetType().GetMethods();
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);
        foreach (PropertyInfo prop in props)
        {
            Console.WriteLine(prop.Name);
        }
        Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
