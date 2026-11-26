
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ScottPlot.WinForms;

using Color = System.Drawing.Color;
using Label = System.Windows.Forms.Label;

namespace Student_Information_System
{
    public partial class DashboardForm : Form
    {
        private readonly int userId;

        private static readonly Color Primary = ColorTranslator.FromHtml("#1E5192");
        private static readonly Color Accent = ColorTranslator.FromHtml("#2563EB");
        private static readonly Color Background = ColorTranslator.FromHtml("#F1F5F9");
        private static readonly Color TextMuted = ColorTranslator.FromHtml("#6B7280");

        private static readonly string[] ChartColors =
        {
            "#2563EB", "#16A34A", "#F59E0B", "#DC2626",
            "#7C3AED", "#0891B2", "#DB2777", "#65A30D"
        };

        private readonly FormsPlot plotCourse = new FormsPlot { Dock = DockStyle.Fill };
        private readonly FormsPlot plotYear = new FormsPlot { Dock = DockStyle.Fill };

        private readonly Button btnRefresh = new Button();
        private readonly Button btnExport = new Button();
        private readonly Button btnReturn = new Button();

        private readonly Label lblTotal = new Label();
        private readonly Label lblPrograms = new Label();
        private readonly Label lblTopProgram = new Label();
        private readonly Label lblYearLevels = new Label();
        private readonly Label lblUpdated = new Label();

        public DashboardForm(int userId)
        {
            InitializeComponent();

            this.userId = userId;

            BuildLayout();
            LoadDashboard();
        }

        private void BuildLayout()
        {
            Text = "Student Analytics Dashboard";
            Size = new Size(1150, 720);
            MinimumSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Background;
            Font = new Font("Segoe UI", 9);

            var root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4
            };

            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 85));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 120));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 32));

            var header = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Primary
            };

            var title = new Label
            {
                Text = "Student Analytics Dashboard",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(24, 10),
                BackColor = Color.Transparent
            };

            var subtitle = new Label
            {
                Text = "Live enrollment overview from the student database",
                ForeColor = ColorTranslator.FromHtml("#BFDBFE"),
                Font = new Font("Segoe UI", 10),
                AutoSize = true,
                Location = new Point(27, 52),
                BackColor = Color.Transparent
            };

            StyleButton(btnRefresh, "Refresh Dashboard", Accent);
            StyleButton(btnExport, "Export Charts", ColorTranslator.FromHtml("#16A34A"));
            StyleButton(btnReturn, "Return to Main UI", ColorTranslator.FromHtml("#64748B"));

            header.Controls.AddRange(new Control[]
            {
                title, subtitle, btnRefresh, btnExport, btnReturn
            });

            header.Resize += (s, e) =>
            {
                btnReturn.Location = new Point(
                    header.Width - btnReturn.Width - 24, 22);

                btnRefresh.Location = new Point(
                    btnReturn.Left - btnRefresh.Width - 12, 22);

                btnExport.Location = new Point(
                    btnRefresh.Left - btnExport.Width - 12, 22);
            };

            btnRefresh.Click += (s, e) => LoadDashboard();
            btnExport.Click += (s, e) => ExportCharts();
            btnReturn.Click += (s, e) => Close();

            var cards = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 1,
                Padding = new Padding(18, 14, 18, 0)
            };

            for (int i = 0; i < 4; i++)
                cards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

            cards.Controls.Add(CreateCard("TOTAL STUDENTS", lblTotal, Accent), 0, 0);
            cards.Controls.Add(CreateCard("PROGRAMS", lblPrograms, Color.Green), 1, 0);
            cards.Controls.Add(CreateCard("TOP PROGRAM", lblTopProgram, Color.Orange), 2, 0);
            cards.Controls.Add(CreateCard("YEAR LEVELS", lblYearLevels, Color.Purple), 3, 0);

            var charts = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                Padding = new Padding(18, 6, 18, 6)
            };

            charts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55));
            charts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));

            charts.Controls.Add(WrapInCard(plotCourse, "Students by Course"), 0, 0);
            charts.Controls.Add(WrapInCard(plotYear, "Students by Year Level"), 1, 0);

            lblUpdated.Dock = DockStyle.Fill;
            lblUpdated.TextAlign = ContentAlignment.MiddleCenter;
            lblUpdated.ForeColor = TextMuted;

            root.Controls.Add(header, 0, 0);
            root.Controls.Add(cards, 0, 1);
            root.Controls.Add(charts, 0, 2);
            root.Controls.Add(lblUpdated, 0, 3);

            Controls.Add(root);
        }

        private static void StyleButton(Button button, string text, Color color)
        {
            button.Text = text;
            button.AutoSize = true;
            button.MinimumSize = new Size(150, 40);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = color;
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
        }

        private Panel CreateCard(string caption, Label valueLabel, Color accent)
        {
            var card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Margin = new Padding(6)
            };

            var strip = new Panel
            {
                Dock = DockStyle.Left,
                Width = 6,
                BackColor = accent
            };

            var cap = new Label
            {
                Text = caption,
                ForeColor = TextMuted,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(18, 15)
            };

            valueLabel.Text = "0";
            valueLabel.ForeColor = ColorTranslator.FromHtml("#1F2937");
            valueLabel.Font = caption == "TOP PROGRAM"
                ? new Font("Segoe UI", 12, FontStyle.Bold)
                : new Font("Segoe UI", 19, FontStyle.Bold);
            valueLabel.AutoSize = true;
            valueLabel.Location = new Point(18, 42);

            card.Controls.Add(valueLabel);
            card.Controls.Add(cap);
            card.Controls.Add(strip);

            return card;
        }

        private Panel WrapInCard(FormsPlot plot, string title)
        {
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(10),
                Margin = new Padding(6)
            };

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 1
            };

            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            var label = new Label
            {
                Text = title,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Primary,
                TextAlign = ContentAlignment.MiddleLeft
            };

            layout.Controls.Add(label, 0, 0);
            layout.Controls.Add(plot, 0, 1);

            panel.Controls.Add(layout);

            return panel;
        }

        private DataTable GetStudentData()
        {
            DataTable table = new DataTable();

            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT student_id, full_name, course, year_level
                    FROM students
                    WHERE user_id = @userId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }

        private void LoadDashboard()
        {
            try
            {
                DataTable students = GetStudentData();

                lblTotal.Text = students.Rows.Count.ToString();

                var courses = students.AsEnumerable()
                    .GroupBy(row => row["course"].ToString())
                    .OrderByDescending(group => group.Count())
                    .ToList();

                lblPrograms.Text = courses.Count.ToString();

                lblTopProgram.Text = courses.Count > 0
                    ? courses[0].Key
                    : "None";

                var years = students.AsEnumerable()
                    .Select(row => row["year_level"].ToString())
                    .Distinct()
                    .ToList();

                lblYearLevels.Text = years.Count.ToString();

                LoadCourseChart(students);
                LoadYearChart(students);

                lblUpdated.Text =
                    "Last updated: " +
                    DateTime.Now.ToString("MMM dd, yyyy hh:mm tt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load dashboard data.\n\n" + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadCourseChart(DataTable students)
        {
            plotCourse.Plot.Clear();

            var data = students.AsEnumerable()
                .GroupBy(row => row["course"].ToString())
                .Select(group => new
                {
                    Name = group.Key,
                    Count = group.Count()
                })
                .OrderByDescending(x => x.Count)
                .ToList();

            if (data.Count == 0)
            {
                plotCourse.Refresh();
                return;
            }

            double total = data.Sum(x => x.Count);

            var slices = new System.Collections.Generic.List<ScottPlot.PieSlice>();

            for (int i = 0; i < data.Count; i++)
            {
                double percentage = data[i].Count / total * 100;

                slices.Add(new ScottPlot.PieSlice
                {
                    Value = data[i].Count,
                    Label = $"{percentage:0.0}%",
                    LegendText = $"{data[i].Name} ({data[i].Count})",
                    FillColor = ScottPlot.Color.FromHex(
                        ChartColors[i % ChartColors.Length])
                });
            }

            var pie = plotCourse.Plot.Add.Pie(slices);

            pie.ExplodeFraction = 0.04;
            pie.SliceLabelDistance = 0.65;

            for (int i = 0; i < pie.Slices.Count; i++)
            {
                pie.Slices[i].LabelFontSize = 13;
                pie.Slices[i].LabelBold = true;
                pie.Slices[i].LabelFontColor = ScottPlot.Colors.White;
            }

            plotCourse.Plot.Axes.Frameless();
            plotCourse.Plot.HideGrid();
            plotCourse.Plot.ShowLegend();

            plotCourse.Refresh();
        }

        private void LoadYearChart(DataTable students)
        {
            plotYear.Plot.Clear();

            var data = students.AsEnumerable()
                .GroupBy(row => row["year_level"].ToString())
                .Select(group => new
                {
                    Name = group.Key,
                    Count = group.Count()
                })
                .OrderBy(x => x.Name)
                .ToList();

            if (data.Count == 0)
            {
                plotYear.Refresh();
                return;
            }

            double[] values = data.Select(x => (double)x.Count).ToArray();

            double[] positions = Enumerable.Range(0, data.Count)
                .Select(x => (double)x).ToArray();

            var bars = plotYear.Plot.Add.Bars(values);

            for (int i = 0; i < bars.Bars.Count; i++)
            {
                bars.Bars[i].FillColor =
                    ScottPlot.Color.FromHex(
                        ChartColors[i % ChartColors.Length]);

                bars.Bars[i].Label = bars.Bars[i].Value.ToString();
            }

            bars.ValueLabelStyle.Bold = true;
            bars.ValueLabelStyle.FontSize = 14;

            plotYear.Plot.Axes.Bottom.SetTicks(
                positions,
                data.Select(x => x.Name ?? "Unknown").ToArray());

            plotYear.Plot.Axes.Bottom.Label.Text = "Year Level";
            plotYear.Plot.Axes.Left.Label.Text = "Number of Students";

            plotYear.Plot.Axes.Margins(bottom: 0, top: 0.15);

            plotYear.Refresh();
        }

        private void ExportCharts()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select folder to export dashboard charts";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                string coursePath = Path.Combine(
                    dialog.SelectedPath, "StudentsByCourse.png");

                string yearPath = Path.Combine(
                    dialog.SelectedPath, "StudentsByYearLevel.png");

                plotCourse.Plot.SavePng(coursePath, 1000, 700);
                plotYear.Plot.SavePng(yearPath, 1000, 700);

                MessageBox.Show(
                    "Charts exported successfully!",
                    "Export Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
