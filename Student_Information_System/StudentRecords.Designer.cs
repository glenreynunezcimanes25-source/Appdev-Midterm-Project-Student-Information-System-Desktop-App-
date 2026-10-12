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
            pictureBox2 = new PictureBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            btnSave = new Button();
            label7 = new Label();
            txtCourse = new TextBox();
            txtFullName = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Profilebox).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 152);
            panel1.TabIndex = 0;
            // 
            // btnProfileMenu
            // 
            btnProfileMenu.BackgroundImageLayout = ImageLayout.None;
            btnProfileMenu.FlatStyle = FlatStyle.Flat;
            btnProfileMenu.ForeColor = Color.Black;
            btnProfileMenu.Location = new Point(1286, 52);
            btnProfileMenu.Name = "btnProfileMenu";
            btnProfileMenu.Size = new Size(30, 31);
            btnProfileMenu.TabIndex = 7;
            btnProfileMenu.Text = "▼";
            btnProfileMenu.UseVisualStyleBackColor = true;
            btnProfileMenu.Click += btnProfileMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
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
            ProfileMenu.Items.AddRange(new object[] { "Edit profile", "Menu", "View students", "Logout" });
            ProfileMenu.Location = new Point(1288, 52);
            ProfileMenu.Margin = new Padding(0);
            ProfileMenu.Name = "ProfileMenu";
            ProfileMenu.Size = new Size(16, 31);
            ProfileMenu.TabIndex = 5;
            ProfileMenu.SelectedIndexChanged += ProfileMenu_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(1231, 57);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Profile";
            // 
            // Profilebox
            // 
            Profilebox.Image = (Image)resources.GetObject("Profilebox.Image");
            Profilebox.Location = new Point(1199, 53);
            Profilebox.Name = "Profilebox";
            Profilebox.Size = new Size(29, 27);
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
            lblSubheader.Location = new Point(141, 71);
            lblSubheader.Name = "lblSubheader";
            lblSubheader.Size = new Size(344, 38);
            lblSubheader.TabIndex = 1;
            lblSubheader.Text = "Manage Student Records";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = SystemColors.ButtonFace;
            lblHeader.Location = new Point(93, 27);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(511, 50);
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
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtCourse);
            panel3.Controls.Add(txtFullName);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(57, 239);
            panel3.Name = "panel3";
            panel3.Size = new Size(446, 528);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(37, 99, 235);
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnUpdate.Location = new Point(144, 75);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 44);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "✎ Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 38, 38);
            btnDelete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnDelete.Location = new Point(264, 75);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 44);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "✖ Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(22, 163, 74);
            btnAdd.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnAdd.Location = new Point(25, 75);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 44);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "＋ Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnClear.Location = new Point(229, 447);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(155, 44);
            btnClear.TabIndex = 8;
            btnClear.Text = "✕ Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(39, 116, 195);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(26, 447);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(155, 44);
            btnSave.TabIndex = 7;
            btnSave.Text = "▣ Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 334);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 6;
            label7.Text = "Year Level";
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(26, 264);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(358, 31);
            txtCourse.TabIndex = 5;
            txtCourse.TextChanged += textCourse_TextChanged;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(26, 165);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(358, 31);
            txtFullName.TabIndex = 4;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 364);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(358, 33);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Select year level";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 236);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 2;
            label6.Text = "Course";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 137);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 1;
            label5.Text = "Full Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 23);
            label2.Name = "label2";
            label2.Size = new Size(160, 31);
            label2.TabIndex = 0;
            label2.Text = "Student Form";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 165);
            label3.Name = "label3";
            label3.Size = new Size(296, 54);
            label3.TabIndex = 4;
            label3.Text = "Welcome back";
            label3.Click += label3_Click;
            // 
            // StudentRecords
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.FromArgb(246, 249, 253);
            ClientSize = new Size(1374, 894);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1024, 700);
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
        private TextBox txtCourse;
        private Button btnClear;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private PictureBox pictureBox2;
    }
}