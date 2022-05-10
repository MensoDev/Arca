namespace Arca.Attributes;
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class PropertyNameAttribute : Attribute
{
    public PropertyNameAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; private init; }
}