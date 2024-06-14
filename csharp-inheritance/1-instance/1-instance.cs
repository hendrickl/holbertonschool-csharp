using System;

// Provides utility methods for object type checking.
class Obj
{
    /// <summary>
    /// Determines whether the specified object is an instance of an array.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns><c>true</c> if the object is an instance of an array; otherwise, <c>false</c>.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj.GetType() == typeof(Array) || obj is Array)
            return true;
        else
            return false;
    }
}