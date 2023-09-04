using SampleApp.Model;
using SampleApp.UI;

namespace SampleApp
{
    public partial class Form1 : Form
    {
        private Gepeszet _gepeszet = new();
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
            var result = await _gepeszet.LoadFromFile("Assets\\sampledataset.json");

            if (!result) { return false; }

            dgData.DataSource = _gepeszet.Elemek;

            return result;
        }

        private void dgData_SelectionChanged(object sender, EventArgs e)
        {
            pnlDetails.Controls.Clear();
            if (dgData.SelectedRows.Count == 0) return;

            var ge = dgData.SelectedRows?[0]?.DataBoundItem as IGepeszetElem;
            GepeszetView control;

            switch (ge)
            {
                case IFutes futes:
                    control = new FutesView(futes);
                    control.Show();
                    pnlDetails.Controls.Add(control);
                    break;
                case IHutes futes:
                    control = new HutesView(futes);
                    control.Show();
                    pnlDetails.Controls.Add(control);
                    break;
                    //case Truck truck:
                    //    WriteLine("Truck!");
                    //    break;
                    //case null:
                    //    throw new ArgumentNullException();
                    //    break;
                    //default:
                    //    // Anything other than Car, Truck or null
                    //    throw new UnknownVehicleException();
                    //    break;
            }
        }
    }
}