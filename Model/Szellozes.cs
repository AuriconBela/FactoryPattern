namespace SampleApp.Model;

public class Szellozes : GepeszetElem, ISzellozes
{
    public Szellozes() : base() => ClassType = Model.ClassType.Szellozes;

    public string SzellozesreJellemzoAdat1 { get; set; } = "A tudástól az ember szelídebb lesz, míg a tudatlanság megkeményíti a szívet.";
    public int SzellozesreJellemzoAdat2 { get; set; } = 252;
}
