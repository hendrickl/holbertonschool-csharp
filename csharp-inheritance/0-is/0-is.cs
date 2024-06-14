using System;

// Provides utility methods for object type checking.
class Obj
{
    /// <summary>
    /// Determines whether the specified object is of type <see cref="System.Int32"/>.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns><c>true</c> if the object is of type <see cref="System.Int32"/>; otherwise, <c>false</c>.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;
        else
            return false;
    }
}
