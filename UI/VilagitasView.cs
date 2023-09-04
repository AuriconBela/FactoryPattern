using SampleApp.Model;

namespace SampleApp.UI;

public partial class VilagitasView : GepeszetView
{
    public VilagitasView()
    {
        InitializeComponent();
    }

    public VilagitasView(IGepeszetElem gepeszetElem) : base(gepeszetElem)
    {
        InitializeComponent();
    }

    protected override void FillView()
    {
        base.FillView();
        label1.Text = (_gepeszetElem as IVilagitas)?.VilagitasraJellemzoAdat.ToString();
    }
}
