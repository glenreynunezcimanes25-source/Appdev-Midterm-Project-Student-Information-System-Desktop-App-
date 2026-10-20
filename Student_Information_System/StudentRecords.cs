using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using MySql.Data.MySqlClient;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Colors = QuestPDF.Helpers.Colors;

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

                    string query = @"
                SELECT student_id, full_name, course, year_level
                FROM students
                WHERE user_id = @userId
                ORDER BY student_id ASC;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@userId", currentLoggedInUserId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            ID.DataPropertyName = "student_id";
                            FullName.DataPropertyName = "full_name";
                            Course.DataPropertyName = "course";
                            YearLevel.DataPropertyName = "year_level";

                            dgvStudentData.AutoGenerateColumns = false;
                            dgvStudentData.DataSource = dt;

                            lblTotalStudents.Text = "Total: " + dt.Rows.Count;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading student data: " + ex.Message,
                    "Database Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {

            LoadStudentData();
        }



        private void ProfileMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProfileMenu.SelectedItem == null)
                return;

            string selectedOption = ProfileMenu.SelectedItem.ToString() ?? "";

            if (selectedOption == "Logout")
            {
                this.Hide();

                LoginForm login = new LoginForm();
                login.Show();
            }
            else if (selectedOption == "Export table as pdf")
            {
                try
                {
                    DataTable dt = dgvStudentData.DataSource as DataTable ?? new DataTable();

                    if (dt == null || dt.Rows.Count == 0)
                    {
                        MessageBox.Show("There are no student records to export.");
                        return;
                    }

                    using (SaveFileDialog sfd = new SaveFileDialog()
                    {
                        Filter = "PDF Document|*.pdf",
                        FileName = "Student_Report.pdf"
                    })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            Document.Create(container =>
                            {
                                container.Page(page =>
                                {
                                    page.Margin(30);

                                    page.Header()
                                        .Text("Student Records Report")
                                        .FontSize(16)
                                        .Bold()
                                        .FontColor(Colors.Blue.Medium);

                                    page.Content().Column(col =>
                                    {
                                        col.Item().PaddingVertical(5)
                                            .Text($"Generated Date: {DateTime.Now:MMMM dd, yyyy}");

                                        col.Item().PaddingVertical(5)
                                            .Text($"Total Students: {dt.Rows.Count}")
                                            .Bold();

                                        col.Item().PaddingVertical(10).Table(table =>
                                        {
                                            table.ColumnsDefinition(columns =>
                                            {
                                                columns.RelativeColumn();
                                                columns.RelativeColumn(2);
                                                columns.RelativeColumn(2);
                                                columns.RelativeColumn();
                                            });

                                            table.Header(header =>
                                            {
                                                header.Cell().Element(CellStyle).Text("ID").Bold();
                                                header.Cell().Element(CellStyle).Text("Full Name").Bold();
                                                header.Cell().Element(CellStyle).Text("Course").Bold();
                                                header.Cell().Element(CellStyle).Text("Year Level").Bold();
                                            });

                                            foreach (DataRow row in dt.Rows)
                                            {
                                                table.Cell().Element(CellStyle)
                                                    .Text(row["Id"]?.ToString() ?? "");

                                                table.Cell().Element(CellStyle)
                                                    .Text(row["FullName"]?.ToString() ?? "");

                                                table.Cell().Element(CellStyle)
                                                    .Text(row["Course"]?.ToString() ?? "");

                                                table.Cell().Element(CellStyle)
                                                    .Text(row["YearLevel"]?.ToString() ?? "");
                                            }
                                        });
                                    });

                                    page.Footer().AlignCenter().Text(x =>
                                    {
                                        x.CurrentPageNumber();
                                        x.Span(" / ");
                                        x.TotalPages();
                                    });
                                });
                            }).GeneratePdf(sfd.FileName);

                            MessageBox.Show(
                                "PDF report generated successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PDF Error: " + ex.Message);
                }
            }
            else if (selectedOption == "Export table as excel")
            {
                try
                {
                    DataTable dt = dgvStudentData.DataSource as DataTable ?? new DataTable();

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("There are no student records to export.");
                        return;
                    }

                    using (SaveFileDialog sfd = new SaveFileDialog()
                    {
                        Filter = "Excel Workbook|*.xlsx",
                        FileName = "Student_Report.xlsx"
                    })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                var worksheet = workbook.Worksheets.Add("Student Records");

                                worksheet.Cell(1, 1).InsertTable(dt);
                                worksheet.Columns().AdjustToContents();

                                workbook.SaveAs(sfd.FileName);
                            }

                            MessageBox.Show(
                                "Excel report exported successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excel Error: " + ex.Message);
                }
            }
            else if (selectedOption == "View students")
            {
                LoadStudentData();
            }
            else if (selectedOption == "Edit profile")
            {
                MessageBox.Show(
                    "Edit profile feature is not implemented yet.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            ProfileMenu.SelectedIndex = -1;
        }
        private static IContainer CellStyle(IContainer container)
        {
            return container
                .Border(1)
                .BorderColor(Colors.Grey.Lighten2)
                .Padding(5);
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
        private void textBox1_TextChanged(object sender, EventArgs e) { SearchStudents(txtSearch.Text.Trim()); }


        private void SearchStudents(string searchText)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT student_id, full_name, course, year_level
                FROM students
                WHERE user_id = @userId
                  AND (
                      student_id LIKE @search
                      OR full_name LIKE @search
                      OR course LIKE @search
                      OR year_level LIKE @search
                  )
                ORDER BY student_id ASC;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@userId", currentLoggedInUserId);

                        cmd.Parameters.AddWithValue(
                            "@search", "%" + searchText + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgvStudentData.DataSource = dt;

                            lblTotalStudents.Text = "Total: " + dt.Rows.Count;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Search failed: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void lblSearch_Click(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStudents(txtSearch.Text.Trim());
        }
    }
}
