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
        Type type = myObj.GetType();
        PropertyInfo[] properties = type.GetProperties();
        MethodInfo[] methods = type.GetMethods();

        if (myObj.GetType() == typeof(int))
        {
            Console.WriteLine($"{type.Name} Properties:");
            Console.WriteLine($"{type.Name} Methods:");
        }
        else
        {
            Console.WriteLine($"{type.Name} Methods:");
        }


        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine($"{property.Name}");
        }


        foreach (MethodInfo method in methods)
        {
            Console.WriteLine($"{method.Name}");
        }
    }
}
