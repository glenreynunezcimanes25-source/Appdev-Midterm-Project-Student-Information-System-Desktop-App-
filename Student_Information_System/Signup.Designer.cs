namespace Student_Information_System
{
    partial class Signup
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
            lblpanel = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblpanel
            // 
            lblpanel.AutoSize = true;
            lblpanel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpanel.ForeColor = Color.White;
            lblpanel.Location = new Point(14, 20);
            lblpanel.Name = "lblpanel";
            lblpanel.Size = new Size(389, 38);
            lblpanel.TabIndex = 0;
            lblpanel.Text = "Student Information System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 38, 71);
            panel1.Controls.Add(lblpanel);
            panel1.Location = new Point(4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 104);
            panel1.TabIndex = 1;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 553);
            Controls.Add(panel1);
            Name = "Signup";
            Text = "Signup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblpanel;
        private Panel panel1;
    }
}