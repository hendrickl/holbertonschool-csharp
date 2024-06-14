using System;
using System.Reflection;

// Provides utility methods for object type inspection.
class Obj
{
    /// <summary>
    /// Prints the names of the available properties and methods of the specified object.
    /// </summary>
    /// <param name="myObj">The object to inspect.</param>
    public static void Print(object myObj)
    {
        // Get the type of the object
        Type type = myObj.GetType();

        // Get the properties of the object
        PropertyInfo[] properties = type.GetProperties();

        // Get the methods of the object
        MethodInfo[] methods = type.GetMethods();

        Console.WriteLine($"{type.Name} Properties:");

        // Print each property name
        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine($"{property.Name}");
        }

        Console.WriteLine($"{type.Name} Methods:");

        // Print each method name
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine($"{method.Name}");
        }
    }
}
