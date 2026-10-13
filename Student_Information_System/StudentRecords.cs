using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Information_System
{
    public partial class StudentRecords : Form
    {
        public StudentRecords()
        {
            InitializeComponent();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void picGradIcons_Click(object sender, EventArgs e)
        {

        }

        private void Profilebox_Click(object sender, EventArgs e)
        {

        }


        private void ProfileMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProfileMenu.SelectedItem == null)
                return;

            string selectedOption = ProfileMenu.SelectedItem.ToString() ?? "";

            switch (selectedOption)
            {
                case "Edit profile":
                    MessageBox.Show(
                        "Profile feature is not implemented yet.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    break;

                case "View students":
                    MessageBox.Show(
                        "View Students feature is not implemented yet.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    break;

                case "Logout":
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to log out?",
                        "Confirm Logout",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        this.Hide();

                        LoginForm login = new LoginForm();
                        login.Show();
                    }
                    break;
            }

            ProfileMenu.SelectedIndex = -1;
        }

        private void btnProfileMenu_Click(object sender, EventArgs e)
        {
            ProfileMenu.Focus();
            ProfileMenu.DroppedDown = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
        }

        private void textCourse_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
} 
