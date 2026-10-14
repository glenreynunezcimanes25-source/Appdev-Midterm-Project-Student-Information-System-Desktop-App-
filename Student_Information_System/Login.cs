using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    public partial class LoginForm : Form
    {
        // Reference your project's database connection class wrapper

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameInput = txtUsername.Text.Trim();
            string passwordInput = txtPassword.Text;

            // 1. Validation Checks
            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Match the correct database layout: user_id, username, password_hash
                    string query = "SELECT user_id FROM users WHERE username = @user AND password_hash = @pass";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", usernameInput);
                        cmd.Parameters.AddWithValue("@pass", passwordInput);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 2. Extract the actual logged-in user's ID from the record
                                int loggedInUserId = Convert.ToInt32(reader["user_id"]);

                                MessageBox.Show("Login successful! Welcome back.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // 3. Hide the login form context layout
                                this.Hide();

                                // 4. Launch the dashboard window passing the extracted user session ID parameter
                                StudentRecords dashboard = new StudentRecords(loggedInUserId);
                                dashboard.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database authentication failed: " + ex.Message, "SQL System Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signup = new SignUpForm();
            signup.FormClosed += (s, args) => this.Show();

            this.Hide();
            signup.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
