using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SampleApp.Model;

namespace SampleApp.Persistence;

public class GepeszetConverter : JsonCreationConverter<GepeszetElem?>
{
    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        serializer.Serialize(writer, value);
    }

    protected override GepeszetElem? Create(Type objectType, JObject jObject)
    {
        if (FieldExists(nameof(ClassType), jObject, out var value))
        {
            var type = typeof(IGepeszetElem).Assembly
                                            .GetTypes()
                                            .Single(t => t.Name == value);

            return type is null ? null : Activator.CreateInstance(type) as GepeszetElem;
        }

        return null;
    }

    private static bool FieldExists(string fieldName, JObject jObject, out string? value)
    {
        value = jObject[fieldName]?.ToString();

        return value is not null;
    }
}
