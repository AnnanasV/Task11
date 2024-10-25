using Attributes;
using System.ComponentModel;
using System.Reflection;
using Task11;

Type type = typeof(SampleClass);

RunSpecify(type, "Anna");

foreach(var method in type.GetMethods())
{
    var attribute = method.GetCustomAttribute<DocumentationAttribute>();
    if(attribute != null)
    {
        Console.WriteLine($"\nMethod:{method.Name}, " +
            $"Author:{attribute.Author}, " +
            $"Version:{attribute.Version}, " +
            $"Description:{attribute.Description}");
    }
}

void RunSpecify (Type type, string author)
{
    var instance = Activator.CreateInstance(type); // create object
    foreach(var method in type.GetMethods())
    {
        var attribute = method.GetCustomAttribute<DocumentationAttribute>();
        if(attribute != null && attribute.Author == author)
        {
            method.Invoke(instance, null); // invoke methods
        }
    }
}