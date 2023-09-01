namespace SampleApp.Model;

public class HasznalatiMelegViz : GepeszetElem, IHasznalatiMelegViz
{
    public HasznalatiMelegViz() : base() => ClassType = Model.ClassType.HasznalatiMelegViz;

    public string HasznalatiMelegVizreJellemzoAdat1 { get; set; } = "Reménytelen dolog meggyőzni olyasvalakit, akinek érvei tömény tudatlanságból fakadnak.";
    public double HasznalatiMelegVizreJellemzoAdat2 { get; set; } = 17.234;
}
