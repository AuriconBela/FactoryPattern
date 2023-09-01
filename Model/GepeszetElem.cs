using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SampleApp.Model;

public abstract class GepeszetElem : IGepeszetElem
{
    [JsonConverter(typeof(StringEnumConverter))]
    public ClassType? ClassType { get; init; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    [JsonConverter(typeof(Persistence.ImageConverter))]
    public Image? Image { get; set; }
}
