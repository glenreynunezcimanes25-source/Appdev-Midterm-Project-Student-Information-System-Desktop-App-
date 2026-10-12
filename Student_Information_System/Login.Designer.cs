namespace Student_Information_System
{
    partial class Login
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
            panel1 = new Panel();
            lblpanel = new Label();
            btnCancel = new Button();
            btnLogin = new Button();
            txtUsername = new TextBox();
            textBox2 = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            checkBox1 = new CheckBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 38, 71);
            panel1.Controls.Add(lblpanel);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 80);
            panel1.TabIndex = 0;
            // 
            // lblpanel
            // 
            lblpanel.AutoSize = true;
            lblpanel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpanel.Location = new Point(14, 20);
            lblpanel.Name = "lblpanel";
            lblpanel.Size = new Size(389, 38);
            lblpanel.TabIndex = 0;
            lblpanel.Text = "Student Information System";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Location = new Point(89, 288);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(0, 0);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(28, 117, 222);
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ImageAlign = ContentAlignment.TopCenter;
            btnLogin.Location = new Point(43, 326);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(346, 42);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(43, 132);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(346, 31);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(43, 231);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(346, 30);
            textBox2.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(43, 106);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 23);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username:";
            lblUsername.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(43, 205);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(84, 23);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(43, 276);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(149, 27);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 376);
            label1.Name = "label1";
            label1.Size = new Size(191, 23);
            label1.TabIndex = 8;
            label1.Text = "Don't have an account?";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(162, 402);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(70, 23);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(432, 453);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(textBox2);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(btnCancel);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblpanel;
        private Button btnCancel;
        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox textBox2;
        private Label lblUsername;
        private Label lblPassword;
        private CheckBox checkBox1;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}
