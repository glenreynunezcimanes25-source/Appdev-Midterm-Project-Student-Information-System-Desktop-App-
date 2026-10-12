namespace Student_Information_System
{
    partial class LoginForm
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
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            chkShowPassword = new CheckBox();
            label1 = new Label();
            lnkSignup = new LinkLabel();
            pnlLogin = new Panel();
            panel1.SuspendLayout();
            pnlLogin.SuspendLayout();
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
            btnCancel.Location = new Point(79, 200);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(0, 0);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(28, 117, 222);
            btnLogin.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ImageAlign = ContentAlignment.TopCenter;
            btnLogin.Location = new Point(33, 238);
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
            txtUsername.Location = new Point(33, 44);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(346, 31);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(33, 143);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(346, 32);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(33, 18);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(101, 25);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username:";
            lblUsername.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(33, 117);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(95, 25);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(33, 188);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(165, 29);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 288);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 8;
            label1.Text = "Don't have an account?";
            label1.Click += label1_Click;
            // 
            // lnkSignup
            // 
            lnkSignup.AutoSize = true;
            lnkSignup.Location = new Point(152, 314);
            lnkSignup.Name = "lnkSignup";
            lnkSignup.Size = new Size(78, 25);
            lnkSignup.TabIndex = 9;
            lnkSignup.TabStop = true;
            lnkSignup.Text = "Sign Up";
            lnkSignup.LinkClicked += lnkSignup_LinkClicked;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = SystemColors.Menu;
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(lnkSignup);
            pnlLogin.Controls.Add(btnCancel);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(chkShowPassword);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(lblUsername);
            pnlLogin.Font = new Font("Segoe UI", 11F);
            pnlLogin.Location = new Point(4, 81);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(425, 368);
            pnlLogin.TabIndex = 10;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(432, 453);
            Controls.Add(pnlLogin);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LoginForm";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblpanel;
        private Button btnCancel;
        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private CheckBox chkShowPassword;
        private Label label1;
        private LinkLabel lnkSignup;
        private Panel pnlLogin;
    }
}
