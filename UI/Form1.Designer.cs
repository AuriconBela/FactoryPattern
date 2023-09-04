namespace SampleApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dgData = new DataGridView();
            pnlDetails = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgData).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 23);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Load data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_ClickAsync;
            // 
            // dgData
            // 
            dgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgData.Location = new Point(12, 52);
            dgData.MultiSelect = false;
            dgData.Name = "dgData";
            dgData.RowTemplate.Height = 25;
            dgData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgData.Size = new Size(447, 386);
            dgData.TabIndex = 1;
            dgData.SelectionChanged += dgData_SelectionChanged;
            // 
            // pnlDetails
            // 
            pnlDetails.Location = new Point(465, 52);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(323, 386);
            pnlDetails.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDetails);
            Controls.Add(dgData);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dgData;
        private Panel pnlDetails;
    }
}