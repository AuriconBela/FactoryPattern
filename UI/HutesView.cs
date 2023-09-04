using SampleApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApp.UI
{
    public partial class HutesView : GepeszetView
    {
        public HutesView()
        {
            InitializeComponent();
        }

        public HutesView(IGepeszetElem gepeszetElem) : base(gepeszetElem)
        {
            InitializeComponent();
        }

        protected override void FillView()
        {
            base.FillView();
            lbAdat.Text = (_gepeszetElem as IHutes)?.HutesreJellemzoAdat1.ToString();
        }
    }
}
