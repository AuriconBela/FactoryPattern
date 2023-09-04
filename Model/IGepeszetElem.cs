using System.ComponentModel;

namespace SampleApp.Model;
public interface IGepeszetElem
{
    [Browsable(false)]
    public ClassType? ClassType { get; init; }
    string? Name { get; set; }
    string? Description { get; set; }
    [Browsable(false)]
    Image? Image { get; set; }
}
