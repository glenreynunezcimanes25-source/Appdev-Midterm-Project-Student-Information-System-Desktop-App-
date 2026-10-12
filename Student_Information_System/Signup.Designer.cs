namespace Student_Information_System
{
    partial class SignUpForm
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
            lblHeader = new Label();
            pnlHolder = new Panel();
            panel2 = new Panel();
            lnkLogin = new LinkLabel();
            label1 = new Label();
            btnCreateAccount = new Button();
            chkShow = new CheckBox();
            txtConfirmpass = new TextBox();
            lblComfirmpass = new Label();
            lblSignUpPass = new Label();
            txtSignUpPass = new TextBox();
            lblSignupUser = new Label();
            txtSignUpUser = new TextBox();
            pnlHolder.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(18, 25);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(389, 38);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Student Information System";
            // 
            // pnlHolder
            // 
            pnlHolder.BackColor = Color.FromArgb(15, 38, 71);
            pnlHolder.Controls.Add(lblHeader);
            pnlHolder.Location = new Point(3, -1);
            pnlHolder.Margin = new Padding(4);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Size = new Size(425, 95);
            pnlHolder.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lnkLogin);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnCreateAccount);
            panel2.Controls.Add(chkShow);
            panel2.Controls.Add(txtConfirmpass);
            panel2.Controls.Add(lblComfirmpass);
            panel2.Controls.Add(lblSignUpPass);
            panel2.Controls.Add(txtSignUpPass);
            panel2.Controls.Add(lblSignupUser);
            panel2.Controls.Add(txtSignUpUser);
            panel2.Font = new Font("Segoe UI", 11F);
            panel2.Location = new Point(3, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 450);
            panel2.TabIndex = 2;
            // 
            // lnkLogin
            // 
            lnkLogin.AutoSize = true;
            lnkLogin.Location = new Point(166, 418);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(59, 25);
            lnkLogin.TabIndex = 15;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Login";
            lnkLogin.LinkClicked += lnkLogin_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 388);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 14;
            label1.Text = "Already have an account?";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(22, 163, 111);
            btnCreateAccount.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCreateAccount.ImageAlign = ContentAlignment.TopCenter;
            btnCreateAccount.Location = new Point(34, 343);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(346, 42);
            btnCreateAccount.TabIndex = 13;
            btnCreateAccount.Text = "Signup";
            btnCreateAccount.UseVisualStyleBackColor = false;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Location = new Point(34, 289);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(165, 29);
            chkShow.TabIndex = 12;
            chkShow.Text = "Show password";
            chkShow.UseVisualStyleBackColor = true;
            chkShow.CheckedChanged += chkShow_CheckedChanged;
            // 
            // txtConfirmpass
            // 
            txtConfirmpass.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmpass.Location = new Point(34, 235);
            txtConfirmpass.Name = "txtConfirmpass";
            txtConfirmpass.Size = new Size(346, 31);
            txtConfirmpass.TabIndex = 11;
            txtConfirmpass.UseSystemPasswordChar = true;
            // 
            // lblComfirmpass
            // 
            lblComfirmpass.AutoSize = true;
            lblComfirmpass.Location = new Point(34, 207);
            lblComfirmpass.Name = "lblComfirmpass";
            lblComfirmpass.Size = new Size(174, 25);
            lblComfirmpass.TabIndex = 10;
            lblComfirmpass.Text = "Comfirm password:";
            // 
            // lblSignUpPass
            // 
            lblSignUpPass.AutoSize = true;
            lblSignUpPass.Location = new Point(34, 110);
            lblSignUpPass.Name = "lblSignUpPass";
            lblSignUpPass.Size = new Size(95, 25);
            lblSignUpPass.TabIndex = 9;
            lblSignUpPass.Text = "Password:";
            // 
            // txtSignUpPass
            // 
            txtSignUpPass.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSignUpPass.Location = new Point(34, 138);
            txtSignUpPass.Name = "txtSignUpPass";
            txtSignUpPass.Size = new Size(346, 31);
            txtSignUpPass.TabIndex = 8;
            txtSignUpPass.UseSystemPasswordChar = true;
            // 
            // lblSignupUser
            // 
            lblSignupUser.AutoSize = true;
            lblSignupUser.Location = new Point(34, 26);
            lblSignupUser.Name = "lblSignupUser";
            lblSignupUser.Size = new Size(101, 25);
            lblSignupUser.TabIndex = 7;
            lblSignupUser.Text = "Username:";
            // 
            // txtSignUpUser
            // 
            txtSignUpUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSignUpUser.Location = new Point(34, 52);
            txtSignUpUser.Name = "txtSignUpUser";
            txtSignUpUser.Size = new Size(346, 31);
            txtSignUpUser.TabIndex = 6;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 553);
            Controls.Add(panel2);
            Controls.Add(pnlHolder);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "SignUpForm";
            Text = "Signup";
            pnlHolder.ResumeLayout(false);
            pnlHolder.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblHeader;
        private Panel pnlHolder;
        private Panel panel2;
        private Label lblSignupUser;
        private TextBox txtSignUpUser;
        private TextBox txtConfirmpass;
        private Label lblComfirmpass;
        private Label lblSignUpPass;
        private TextBox txtSignUpPass;
        private CheckBox chkShow;
        private Button btnCreateAccount;
        private Label label1;
        private LinkLabel lnkLogin;
    }
}