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



        // ===================== CRUD =====================

        private enum FormMode { None, Add, Edit }
        private FormMode mode = FormMode.None;

        private const string YearPlaceholder = "Select year level";

        // Reload the grid, keeping the current search filter if there is one.
        private void RefreshStudents()
        {
            string search = txtSearch.Text.Trim();
            if (search.Length == 0)
                LoadStudentData();
            else
                SearchStudents(search);
        }

        private void ClearForm()
        {
            txtStudentId.Clear();
            txtFullName.Clear();
            txtCourse.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = YearPlaceholder;
            txtStudentId.ReadOnly = false;
            mode = FormMode.None;
            dgvStudentData.ClearSelection();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                MessageBox.Show("Please enter a Student ID.", "Validation Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentId.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter the student's full name.", "Validation Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("Please enter a course.", "Validation Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourse.Focus();
                return false;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a year level.", "Validation Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return false;
            }
            return true;
        }

        // Copy the selected grid row into the input fields.
        private bool LoadSelectedRowIntoForm()
        {
            if (dgvStudentData.CurrentRow == null || dgvStudentData.CurrentRow.IsNewRow)
                return false;

            DataGridViewRow row = dgvStudentData.CurrentRow;
            txtStudentId.Text = row.Cells["ID"].Value?.ToString() ?? "";
            txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
            txtCourse.Text = row.Cells["Course"].Value?.ToString() ?? "";
            comboBox1.SelectedItem = row.Cells["YearLevel"].Value?.ToString();
            return true;
        }

        private void dgvStudentData_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (LoadSelectedRowIntoForm())
            {
                mode = FormMode.Edit;
                txtStudentId.ReadOnly = true;   // primary key cannot be changed
            }
        }

        // CREATE (step 1): prepare an empty form for a new student.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearForm();
            mode = FormMode.Add;
            txtStudentId.Focus();
        }

        // UPDATE (step 1): load the selected student so it can be edited.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!LoadSelectedRowIntoForm())
            {
                MessageBox.Show("Please select a student from the table to update.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            mode = FormMode.Edit;
            txtStudentId.ReadOnly = true;
            txtFullName.Focus();
        }

        // CREATE / UPDATE (final step): write the form data to the database.
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mode == FormMode.None)
            {
                MessageBox.Show("Click 'Add' to create a new student, or select a student and click 'Update'.",
                    "Nothing to Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateForm()) return;

            string id = txtStudentId.Text.Trim();
            string name = txtFullName.Text.Trim();
            string course = txtCourse.Text.Trim();
            string year = comboBox1.SelectedItem!.ToString()!;

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = mode == FormMode.Add
                        ? @"INSERT INTO students (student_id, user_id, full_name, course, year_level)
                            VALUES (@id, @userId, @name, @course, @year);"
                        : @"UPDATE students
                            SET full_name = @name, course = @course, year_level = @year
                            WHERE student_id = @id AND user_id = @userId;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@userId", currentLoggedInUserId);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@course", course);
                        cmd.Parameters.AddWithValue("@year", year);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    mode == FormMode.Add ? "Student added successfully!" : "Student updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                RefreshStudents();
            }
            catch (MySqlException ex) when (ex.Number == 1062)   // duplicate primary key
            {
                MessageBox.Show("A student with ID \"" + id + "\" already exists.",
                    "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save student: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DELETE: remove the selected student after confirmation.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudentData.CurrentRow == null || dgvStudentData.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a student from the table to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string id = dgvStudentData.CurrentRow.Cells["ID"].Value?.ToString() ?? "";
            string name = dgvStudentData.CurrentRow.Cells["FullName"].Value?.ToString() ?? "";

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete {name} (ID: {id})?\nThis cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM students WHERE student_id = @id AND user_id = @userId;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@userId", currentLoggedInUserId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Student deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                RefreshStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete student: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
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
