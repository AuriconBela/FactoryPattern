using SampleApp.Model;

namespace SampleApp.UI
{
    public partial class GepeszetView : UserControl
    {
        private readonly IGepeszetElem _gepeszetElem;

        public GepeszetView()
        {
            InitializeComponent();
        }

        public GepeszetView(IGepeszetElem gepeszetElem) : base()
        {
            _gepeszetElem = gepeszetElem;
        }
    }
}
