namespace SampleApp.Model;
public interface IGepeszetElem
{
    public ClassType? ClassType { get; init; }
    string? Name { get; set; }
    string? Description { get; set; }
    Image? Image { get; set; }
}
