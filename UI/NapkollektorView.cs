using SampleApp.Model;

namespace SampleApp.UI;

public partial class NapkollektorView : GepeszetView
{
    public NapkollektorView()
    {
        InitializeComponent();
    }

    public NapkollektorView(IGepeszetElem gepeszetElem) : base(gepeszetElem)
    {
        InitializeComponent();
    }

    protected override void FillView()
    {
        base.FillView();
        label1.Text = (_gepeszetElem as INapKollektor)?.NapKollektorraJellemzoAdat1;
        label2.Text = (_gepeszetElem as INapKollektor)?.NapKollektorraJellemzoAdat3.ToString();
        textBox1.Text = (_gepeszetElem as INapKollektor)?.NapKollektorraJellemzoAdat2;
    }
}

