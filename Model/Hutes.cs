namespace SampleApp.Model;

public class Hutes : GepeszetElem, IHutes
{
    public Hutes() : base() => ClassType = Model.ClassType.Hutes;

    public int HutesreJellemzoAdat1 { get; set; } = 235;
}
