namespace SampleApp.Model;

public class NapKollektor : GepeszetElem, INapKollektor
{
    public NapKollektor() : base() => ClassType = Model.ClassType.NapKollektor;

    public string NapKollektorraJellemzoAdat1 { get; set; } = "Amit az ember nem próbál, ahhoz nem is ért.";

    public string NapKollektorraJellemzoAdat2 { get; set; } = "Nem az a lényeg, hogy mid van... hanem az, hogy mit kezdesz vele.";
    public int NapKollektorraJellemzoAdat3 { get; set; } = 25;
}
