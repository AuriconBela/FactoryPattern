using SampleApp.Model;

namespace SampleApp.UI;

public partial class SzellozesView : GepeszetView
{
    public SzellozesView()
    {
        InitializeComponent();
    }

    public SzellozesView(IGepeszetElem gepeszetElem) : base(gepeszetElem)
    {
        InitializeComponent();
    }

    protected override void FillView()
    {
        base.FillView();
        label1.Text = (_gepeszetElem as ISzellozes)?.SzellozesreJellemzoAdat1;
        label2.Text = (_gepeszetElem as ISzellozes)?.SzellozesreJellemzoAdat2.ToString();
    }
}
