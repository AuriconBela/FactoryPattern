namespace SampleApp.UI
{
    partial class FutesView
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
            lbAdat1 = new Label();
            lbAdat2 = new Label();
            SuspendLayout();
            // 
            // lbAdat1
            // 
            lbAdat1.AutoEllipsis = true;
            lbAdat1.Location = new Point(3, 280);
            lbAdat1.Name = "lbAdat1";
            lbAdat1.Size = new Size(317, 30);
            lbAdat1.TabIndex = 4;
            lbAdat1.Text = "label1";
            // 
            // lbAdat2
            // 
            lbAdat2.AutoEllipsis = true;
            lbAdat2.Location = new Point(3, 330);
            lbAdat2.Name = "lbAdat2";
            lbAdat2.Size = new Size(317, 35);
            lbAdat2.TabIndex = 5;
            lbAdat2.Text = "label1";
            // 
            // FutesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbAdat2);
            Controls.Add(lbAdat1);
            Name = "FutesView";
            Controls.SetChildIndex(lbAdat1, 0);
            Controls.SetChildIndex(lbAdat2, 0);
            ResumeLayout(false);
        }

        #endregion
        private Label lbAdat1;
        private Label lbAdat2;
    }
}
