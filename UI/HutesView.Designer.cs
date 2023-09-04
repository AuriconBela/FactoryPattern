namespace SampleApp.UI
{
    partial class HutesView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbAdat = new Label();
            SuspendLayout();
            // 
            // lbAdat
            // 
            lbAdat.AutoSize = true;
            lbAdat.Location = new Point(141, 280);
            lbAdat.Name = "lbAdat";
            lbAdat.Size = new Size(38, 15);
            lbAdat.TabIndex = 3;
            lbAdat.Text = "label1";
            lbAdat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HutesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbAdat);
            Name = "HutesView";
            Controls.SetChildIndex(lbAdat, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAdat;
    }
}
