using System;

// Provides utility methods for type checking.
class Obj
{
    /// <summary>
    /// Determines whether the specified type is a subclass of the specified base type and not the same as the base type.
    /// </summary>
    /// <param name="derivedType">The type to check if it is a subclass.</param>
    /// <param name="baseType">The base type to check against.</param>
    /// <returns><c>true</c> if <paramref name="derivedType"/> is a subclass of <paramref name="baseType"/> and not the same as <paramref name="baseType"/>; otherwise, <c>false</c>.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType) && derivedType != baseType;
    }
}
