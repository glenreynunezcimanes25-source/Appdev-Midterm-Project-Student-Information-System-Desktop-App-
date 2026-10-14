using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Information_System
{
    public partial class StudentRecords : Form
    {
        
        private int currentLoggedInUserId;
        public StudentRecords(int userId)
        {
            InitializeComponent();
            this.currentLoggedInUserId = userId;
            LoadStudentData();
        }

        
        private void LoadStudentData()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    
                    string query = "SELECT student_id, user_id, full_name, course FROM students WHERE user_id = @userId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", currentLoggedInUserId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            
                            foreach (Control c in this.Controls)
                            {
                                if (c is DataGridView dgv)
                                {
                                    dgv.DataSource = dt;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dynamic data: " + ex.Message, "Database Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            LoadStudentData();
        }

        
        private void ProfileMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProfileMenu.SelectedItem == null) return;
            if (ProfileMenu.SelectedItem.ToString() == "Logout")
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
            ProfileMenu.SelectedIndex = -1;
        }

        private void btnProfileMenu_Click(object sender, EventArgs e) { ProfileMenu.Focus(); ProfileMenu.DroppedDown = true; }
        private void lblHeader_Click(object sender, EventArgs e) { }
        private void picGradIcons_Click(object sender, EventArgs e) { }
        private void Profilebox_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void txtFullName_TextChanged(object sender, EventArgs e) { }
        private void textCourse_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void lblSearch_Click(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
