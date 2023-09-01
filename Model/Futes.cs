namespace SampleApp.Model;
public class Futes : GepeszetElem, IFutes
{
    public Futes() : base() => ClassType = Model.ClassType.Futes;

    public string FutesreJellemzoAdat1 { get; set; } = "Saját magunk megismerése a bölcsesség kezdete.";
    public string FutesreJellemzoAdat2 { get; set; } = "Szabadság az, amikor azt teheted mindig, ami szép.";
}
