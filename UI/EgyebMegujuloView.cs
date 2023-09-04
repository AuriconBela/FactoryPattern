using SampleApp.Model;

namespace SampleApp.UI;

public partial class EgyebMegujuloView : GepeszetView
{
    public EgyebMegujuloView()
    {
        InitializeComponent();
    }

    public EgyebMegujuloView(IGepeszetElem gepeszetElem) : base(gepeszetElem)
    {
        InitializeComponent();
    }

    protected override void FillView()
    {
        base.FillView();
        textBox1.Text = (_gepeszetElem as IEgyebMegujulo)?.EgyebMegujuloraJellemzoAdat1.ToString();
        textBox2.Text = (_gepeszetElem as IEgyebMegujulo)?.EgyebMegujuloraJellemzoAdat2.ToString();
    }
}

