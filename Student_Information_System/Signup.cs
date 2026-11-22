using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    public partial class SignUpForm : Form
    {

        public SignUpForm()
        {
            InitializeComponent();
        }

        
        private void btnSignup_Click(object sender, EventArgs e)
        {
           
            string usernameInput = txtSignUpUser.Text.Trim();

            
            if (string.IsNullOrEmpty(usernameInput))
            {
                MessageBox.Show("Please enter a username registration parameter entry.", "Validation Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtSignUpPass.Text) || string.IsNullOrEmpty(txtConfirmpass.Text))
            {
                MessageBox.Show("Password entry blocks cannot be left empty.", "Validation Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSignUpPass.Text != txtConfirmpass.Text)
            {
                MessageBox.Show("Passwords do not match! Please verify your inputs.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using(MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO users (username, password_hash) VALUES (@user, @pass)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", usernameInput);
                        cmd.Parameters.AddWithValue("@pass", txtSignUpPass.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        this.Hide();
                        LoginForm login = new LoginForm();
                        login.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database registration failed: " + ex.Message, "SQL System Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtSignUpPass.UseSystemPasswordChar = !chkShow.Checked;
            txtConfirmpass.UseSystemPasswordChar = !chkShow.Checked;
        }
    }
}
