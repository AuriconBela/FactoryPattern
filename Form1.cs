using SampleApp.Model;

namespace SampleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            var gepeszet = new Gepeszet();
            //await gepeszet.CreateSampleDataAsync("Assets\\sampledataset.json");

            await gepeszet.LoadFromFile("Assets\\sampledataset.json");
        }
    }
}