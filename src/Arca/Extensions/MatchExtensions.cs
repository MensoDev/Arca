using System.Reflection;
using System.Text.RegularExpressions;
using Arca.Attributes;

namespace Arca.Extensions;

public static class MatchExtensions
{
    public static T SimpleDeserializer<T>(this Match match) where T : class, new()
    {
        var instance = Activator.CreateInstance<T>();
        var properties = typeof(T)
            .GetProperties()
            .Where(prop => prop.GetCustomAttribute<PropertyNameAttribute>() is not null);

        foreach (var property in properties)
        {
            var propertyName = property.GetCustomAttribute<PropertyNameAttribute>()?.Name ?? string.Empty;
            property.SetValue(instance, match.Groups[propertyName].Value);
        }

        return instance;
    } 
}