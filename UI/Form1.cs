using SampleApp.Model;
using SampleApp.Persistence;
using SampleApp.UI;

namespace SampleApp
{
    public partial class Form1 : Form
    {
        private Gepeszet _gepeszet = new(new Repository("Assets\\sampledataset.json"));
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            if (!await FillGrid())
            {
                MessageBox.Show("Something unexpected happened :(");
                return;
            }
        }

        private async Task<bool> FillGrid()
        {
            var result = await _gepeszet.RetrieveElements();

            if (!result) { return false; }

            dgData.DataSource = _gepeszet.Elemek;

            return result;
        }

        private void dgData_SelectionChanged(object sender, EventArgs e)
        {
            pnlDetails.Controls.Clear();

            if (dgData.SelectedRows.Count == 0) return;

            var ge = dgData.SelectedRows?[0]?.DataBoundItem as IGepeszetElem;
            var control = ViewFactory.CreateView(ge);

            if (control == null) return;

            control.Show();
            pnlDetails.Controls.Add(control);
        }
    }
}