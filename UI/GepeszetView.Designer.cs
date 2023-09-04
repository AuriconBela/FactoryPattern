namespace SampleApp.UI
{
    partial class GepeszetView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GepeszetView));
            lbName = new Label();
            lbDesc = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoEllipsis = true;
            lbName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.Location = new Point(3, 9);
            lbName.Name = "lbName";
            lbName.Size = new Size(307, 15);
            lbName.TabIndex = 0;
            lbName.Text = "lbName";
            // 
            // lbDesc
            // 
            lbDesc.AutoEllipsis = true;
            lbDesc.Location = new Point(3, 35);
            lbDesc.Name = "lbDesc";
            lbDesc.Size = new Size(317, 15);
            lbDesc.TabIndex = 1;
            lbDesc.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // GepeszetView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(pictureBox1);
            Controls.Add(lbDesc);
            Controls.Add(lbName);
            Name = "GepeszetView";
            Size = new Size(323, 386);
            Load += GepeszetView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbName;
        private Label lbDesc;
        private PictureBox pictureBox1;
    }
}
