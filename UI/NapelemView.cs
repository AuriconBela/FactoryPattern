using SampleApp.Model;

namespace SampleApp.UI;

public partial class NapelemView : GepeszetView
{
    public NapelemView()
    {
        InitializeComponent();
    }

    public NapelemView(IGepeszetElem gepeszetElem) : base(gepeszetElem)
    {
        InitializeComponent();
    }

    protected override void FillView()
    {
        base.FillView();
        label1.Text = (_gepeszetElem as INapelem)?.NapelemreJellemzoAdat1;
        label2.Text = (_gepeszetElem as INapelem)?.NapelemreJellemzoAdat2;
        textBox1.Text = (_gepeszetElem as INapelem)?.NapelemreJellemzoAdat3;
    }
}
