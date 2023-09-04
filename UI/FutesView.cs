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
    public partial class FutesView : GepeszetView
    {
        public FutesView()
        {
            InitializeComponent();
        }

        public FutesView(IGepeszetElem gepeszetElem) : base(gepeszetElem)
        {
            InitializeComponent();
        }

        protected override void FillView()
        {
            base.FillView();
            lbAdat1.Text = (_gepeszetElem as IFutes)?.FutesreJellemzoAdat1;
            lbAdat2.Text = (_gepeszetElem as IFutes)?.FutesreJellemzoAdat2;
        }
    }
}
