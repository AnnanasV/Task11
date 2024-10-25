using Attributes;
using System.Reflection;
using Task11;

Type type = typeof(SampleClass);

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