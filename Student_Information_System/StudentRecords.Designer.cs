namespace Student_Information_System
{
    partial class StudentRecords
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblHeader = new Label();
            lblSubheader = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 82, 147);
            panel1.Controls.Add(lblSubheader);
            panel1.Controls.Add(lblHeader);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 100);
            panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(93, 11);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(415, 41);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Student Information System";
            lblHeader.Click += lblHeader_Click;
            // 
            // lblSubheader
            // 
            lblSubheader.AutoSize = true;
            lblSubheader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubheader.Location = new Point(137, 52);
            lblSubheader.Name = "lblSubheader";
            lblSubheader.Size = new Size(249, 28);
            lblSubheader.TabIndex = 1;
            lblSubheader.Text = "Manage Student Records";
            // 
            // StudentRecords
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.FromArgb(246, 249, 253);
            ClientSize = new Size(1006, 653);
            Controls.Add(panel1);
            MaximumSize = new Size(1024, 700);
            Name = "StudentRecords";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Records";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblHeader;
        private Label lblSubheader;
    }
}