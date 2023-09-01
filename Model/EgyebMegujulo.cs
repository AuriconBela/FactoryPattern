namespace SampleApp.Model;

public class EgyebMegujulo : GepeszetElem, IEgyebMegujulo
{
    public EgyebMegujulo() : base() => ClassType = Model.ClassType.EgyebMegujulo;

    public double EgyebMegujuloraJellemzoAdat1 { get; set; } = 17.234;
    public double EgyebMegujuloraJellemzoAdat2 { get; set; } = 27.234;
}
