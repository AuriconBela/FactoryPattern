using SampleApp.Model;

namespace SampleApp.UI;

public partial class HMVView : GepeszetView
{
    public HMVView()
    {
        InitializeComponent();
    }

    public HMVView(IGepeszetElem gepeszetElem) : base(gepeszetElem)
    {
        InitializeComponent();
    }

    protected override void FillView()
    {
        base.FillView();
        label1.Text = (_gepeszetElem as IHasznalatiMelegViz)?.HasznalatiMelegVizreJellemzoAdat1;
        label2.Text = (_gepeszetElem as IHasznalatiMelegViz)?.HasznalatiMelegVizreJellemzoAdat2.ToString();
    }
}
