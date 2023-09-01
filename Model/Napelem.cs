namespace SampleApp.Model;

public class Napelem : GepeszetElem, INapelem
{
    public Napelem() : base() => ClassType = Model.ClassType.Napelem;

    public string NapelemreJellemzoAdat1 { get; set; } = "Elhalasztott döntésekkel többet lehet veszíteni, mint rossz döntésekkel.";
    public string NapelemreJellemzoAdat2 { get; set; } = "Mindannyian úgy érezzük, hogy a saját hibánk a legsúlyosabb, mert azt mi követtük el. Mindannyian együtt élünk a tetteink okozta bűntudattal.";

    public string NapelemreJellemzoAdat3 { get; set; } = "A hazugságok mindig újabb hazugságokat szülnek.";
}
