namespace SampleApp.Misc;

public static class Extensions
{
    public static T? GetAttribute<T>(this Enum enumValue)
        where T : Attribute
    {
        var field = enumValue.GetType().GetField(enumValue.ToString());
        var attribs = field?.GetCustomAttributes(typeof(T), false);

        T? result = default!;

        if (attribs?.Length > 0)
        {
            result = attribs[0] as T;
        }

        return result;
    }
}