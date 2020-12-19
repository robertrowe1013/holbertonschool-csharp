using System;

class Obj
{
    /// <summary>
    /// check subclass
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}
