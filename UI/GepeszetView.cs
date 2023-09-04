using SampleApp.Model;

namespace SampleApp.UI
{
    public partial class GepeszetView : UserControl
    {
        protected readonly IGepeszetElem? _gepeszetElem;

        public GepeszetView()
        {
            InitializeComponent();
        }

        public GepeszetView(IGepeszetElem gepeszetElem) : base()
        {
            InitializeComponent();
            _gepeszetElem = gepeszetElem;
        }

        protected virtual void FillView()
        {
            lbName.Text = _gepeszetElem?.Name;
            lbDesc.Text = _gepeszetElem?.Description;
            pictureBox1.Image = _gepeszetElem?.Image;
        }

        private void GepeszetView_Load(object sender, EventArgs e)
        {
            FillView();
        }
    }
}
