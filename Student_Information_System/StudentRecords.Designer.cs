namespace Student_Information_System
{
    partial class StudentRecords
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRecords));
            panel1 = new Panel();
            btnProfileMenu = new Button();
            pictureBox1 = new PictureBox();
            ProfileMenu = new ComboBox();
            label1 = new Label();
            Profilebox = new PictureBox();
            lblSubheader = new Label();
            lblHeader = new Label();
            imageList1 = new ImageList(components);
            panel3 = new Panel();
            txtStudentId = new TextBox();
            lblStudentId = new Label();
            txtCourse = new TextBox();
            pictureBox2 = new PictureBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            btnSave = new Button();
            label7 = new Label();
            txtFullName = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            lblTotalStudents = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvStudentData = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Course = new DataGridViewTextBoxColumn();
            YearLevel = new DataGridViewTextBoxColumn();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Profilebox).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 82, 147);
            panel1.Controls.Add(btnProfileMenu);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ProfileMenu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Profilebox);
            panel1.Controls.Add(lblSubheader);
            panel1.Controls.Add(lblHeader);
            panel1.Location = new Point(4, -2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 122);
            panel1.TabIndex = 0;
            // 
            // btnProfileMenu
            // 
            btnProfileMenu.FlatStyle = FlatStyle.Flat;
            btnProfileMenu.ForeColor = Color.Black;
            btnProfileMenu.Location = new Point(1027, 41);
            btnProfileMenu.Margin = new Padding(2);
            btnProfileMenu.Name = "btnProfileMenu";
            btnProfileMenu.Size = new Size(24, 29);
            btnProfileMenu.TabIndex = 7;
            btnProfileMenu.Text = "▼";
            btnProfileMenu.UseVisualStyleBackColor = true;
            btnProfileMenu.Click += btnProfileMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 35);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // ProfileMenu
            // 
            ProfileMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProfileMenu.BackColor = Color.White;
            ProfileMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            ProfileMenu.DropDownWidth = 150;
            ProfileMenu.FlatStyle = FlatStyle.Flat;
            ProfileMenu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProfileMenu.FormattingEnabled = true;
            ProfileMenu.Items.AddRange(new object[] { "Export table as pdf", "Export table as excel", "Logout" });
            ProfileMenu.Location = new Point(1030, 42);
            ProfileMenu.Margin = new Padding(0);
            ProfileMenu.Name = "ProfileMenu";
            ProfileMenu.Size = new Size(14, 27);
            ProfileMenu.TabIndex = 5;
            ProfileMenu.SelectedIndexChanged += ProfileMenu_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(985, 46);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 4;
            label1.Text = "Profile";
            // 
            // Profilebox
            // 
            Profilebox.Image = (Image)resources.GetObject("Profilebox.Image");
            Profilebox.Location = new Point(959, 42);
            Profilebox.Margin = new Padding(2);
            Profilebox.Name = "Profilebox";
            Profilebox.Size = new Size(23, 22);
            Profilebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Profilebox.TabIndex = 2;
            Profilebox.TabStop = false;
            Profilebox.Click += Profilebox_Click;
            // 
            // lblSubheader
            // 
            lblSubheader.AutoSize = true;
            lblSubheader.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubheader.ForeColor = SystemColors.ButtonFace;
            lblSubheader.Location = new Point(121, 65);
            lblSubheader.Margin = new Padding(2, 0, 2, 0);
            lblSubheader.Name = "lblSubheader";
            lblSubheader.Size = new Size(272, 30);
            lblSubheader.TabIndex = 1;
            lblSubheader.Text = "Manage Student Records";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = SystemColors.ButtonFace;
            lblHeader.Location = new Point(82, 30);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(415, 41);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Student Information System";
            lblHeader.Click += lblHeader_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(txtStudentId);
            panel3.Controls.Add(lblStudentId);
            panel3.Controls.Add(txtCourse);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtFullName);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(39, 219);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(357, 422);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(21, 128);
            txtStudentId.Margin = new Padding(2);
            txtStudentId.MaxLength = 50;
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(287, 27);
            txtStudentId.TabIndex = 21;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentId.Location = new Point(21, 106);
            lblStudentId.Margin = new Padding(2, 0, 2, 0);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(81, 20);
            lblStudentId.TabIndex = 20;
            lblStudentId.Text = "Student ID";
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(21, 234);
            txtCourse.Margin = new Padding(2);
            txtCourse.MaxLength = 100;
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(287, 27);
            txtCourse.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 12);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(37, 99, 235);
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(115, 60);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 35);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "✎ Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 38, 38);
            btnDelete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnDelete.Location = new Point(211, 60);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 35);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "✖ Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(22, 163, 74);
            btnAdd.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnAdd.Location = new Point(20, 60);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 35);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "＋ Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnClear.Location = new Point(183, 358);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 35);
            btnClear.TabIndex = 8;
            btnClear.Text = "✕ Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(39, 116, 195);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(21, 358);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(124, 35);
            btnSave.TabIndex = 7;
            btnSave.Text = "▣ Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 264);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 6;
            label7.Text = "Year Level";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(21, 181);
            txtFullName.Margin = new Padding(2);
            txtFullName.MaxLength = 100;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(287, 27);
            txtFullName.TabIndex = 4;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1st Year", "2nd Year", "3rd Year", "4th Year" });
            comboBox1.Location = new Point(21, 286);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(287, 27);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Select year level";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 211);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 2;
            label6.Text = "Course";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 158);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 1;
            label5.Text = "Full Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 18);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 0;
            label2.Text = "Student Form";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 132);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(237, 45);
            label3.TabIndex = 4;
            label3.Text = "Welcome back";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(lblTotalStudents);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(dgvStudentData);
            panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(426, 219);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(664, 422);
            panel2.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(17, 77);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 8;
            label9.Text = "Search:";
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.BackColor = SystemColors.Control;
            lblTotalStudents.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalStudents.Location = new Point(580, 74);
            lblTotalStudents.Margin = new Padding(2, 0, 2, 0);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(63, 25);
            lblTotalStudents.TabIndex = 6;
            lblTotalStudents.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 15.2000008F, FontStyle.Bold);
            label4.Location = new Point(82, 21);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(173, 30);
            label4.TabIndex = 5;
            label4.Text = "Student Records";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 12);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(506, 74);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 25);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.CharacterCasing = CharacterCasing.Lower;
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(82, 74);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name, course, or ID...";
            txtSearch.Size = new Size(422, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // dgvStudentData
            // 
            dgvStudentData.AllowUserToAddRows = false;
            dgvStudentData.AllowUserToDeleteRows = false;
            dgvStudentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudentData.BackgroundColor = SystemColors.ActiveCaption;
            dgvStudentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentData.Columns.AddRange(new DataGridViewColumn[] { ID, FullName, Course, YearLevel });
            dgvStudentData.GridColor = SystemColors.HotTrack;
            dgvStudentData.Location = new Point(15, 110);
            dgvStudentData.Margin = new Padding(2);
            dgvStudentData.MultiSelect = false;
            dgvStudentData.Name = "dgvStudentData";
            dgvStudentData.ReadOnly = true;
            dgvStudentData.RowHeadersWidth = 51;
            dgvStudentData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentData.Size = new Size(631, 300);
            dgvStudentData.TabIndex = 0;
            dgvStudentData.CellClick += dgvStudentData_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "student_id";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "full_name";
            FullName.HeaderText = "Full name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Course
            // 
            Course.DataPropertyName = "course";
            Course.HeaderText = "Course";
            Course.MinimumWidth = 6;
            Course.Name = "Course";
            Course.ReadOnly = true;
            // 
            // YearLevel
            // 
            YearLevel.DataPropertyName = "year_level";
            YearLevel.HeaderText = "Year Level";
            YearLevel.MinimumWidth = 6;
            YearLevel.Name = "YearLevel";
            YearLevel.ReadOnly = true;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(32, 175);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(383, 20);
            label8.TabIndex = 6;
            label8.Text = "Manage, add, update, and view students all in one place.";
            // 
            // StudentRecords
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.FromArgb(246, 249, 253);
            ClientSize = new Size(1099, 699);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MinimumSize = new Size(822, 568);
            Name = "StudentRecords";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Records";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Profilebox).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblHeader;
        private Label lblSubheader;
        private PictureBox Profilebox;
        private Label label1;
        private ComboBox ProfileMenu;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private Button btnProfileMenu;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private TextBox txtFullName;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private Label label7;
        private Button btnClear;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private PictureBox pictureBox2;
        private Panel panel2;
        private DataGridView dgvStudentData;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label4;
        private PictureBox pictureBox3;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label lblTotalStudents;
        private Label label8;
        private TextBox txtCourse;
        private TextBox txtStudentId;
        private Label lblStudentId;
        private Label label9;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn YearLevel;
    }
}