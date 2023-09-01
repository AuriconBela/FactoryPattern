namespace SampleApp.Model;

public class Vilagitas : GepeszetElem, IVilagitas
{
    public Vilagitas() : base() => ClassType = Model.ClassType.Vilagitas;
    public int VilagitasraJellemzoAdat { get; set; } = 2520;
}
