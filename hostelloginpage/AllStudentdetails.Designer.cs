
namespace hostelloginpage
{
    partial class AllStudentdetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllStudentdetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnback = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.table_studentsdetails = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnsearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtroom = new System.Windows.Forms.TextBox();
            this.studentsDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelDBDataSet1 = new hostelloginpage.HostelDBDataSet1();
            this.studentsDetailsTableAdapter = new hostelloginpage.HostelDBDataSet1TableAdapters.StudentsDetailsTableAdapter();
            this.guna2ShadowPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_studentsdetails)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.btnback);
            this.guna2ShadowPanel3.Controls.Add(this.table_studentsdetails);
            this.guna2ShadowPanel3.Controls.Add(this.btnsearch);
            this.guna2ShadowPanel3.Controls.Add(this.btnrefresh);
            this.guna2ShadowPanel3.Controls.Add(this.label5);
            this.guna2ShadowPanel3.Controls.Add(this.label3);
            this.guna2ShadowPanel3.Controls.Add(this.guna2ShadowPanel1);
            this.guna2ShadowPanel3.Controls.Add(this.txtroom);
            this.guna2ShadowPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(1283, 908);
            this.guna2ShadowPanel3.TabIndex = 15;
            // 
            // btnback
            // 
            this.btnback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnback.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnback.FillColor = System.Drawing.Color.Transparent;
            this.btnback.FillColor2 = System.Drawing.Color.Transparent;
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.ImageSize = new System.Drawing.Size(80, 80);
            this.btnback.Location = new System.Drawing.Point(12, 195);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(101, 58);
            this.btnback.TabIndex = 70;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // table_studentsdetails
            // 
            this.table_studentsdetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_studentsdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_studentsdetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table_studentsdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_studentsdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column1});
            this.table_studentsdetails.Location = new System.Drawing.Point(12, 438);
            this.table_studentsdetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table_studentsdetails.Name = "table_studentsdetails";
            this.table_studentsdetails.RowHeadersWidth = 51;
            this.table_studentsdetails.RowTemplate.Height = 24;
            this.table_studentsdetails.Size = new System.Drawing.Size(1259, 459);
            this.table_studentsdetails.TabIndex = 69;
            this.table_studentsdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_studentsdetails_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Regno";
            this.Column2.HeaderText = "Regno";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Fullname";
            this.Column3.HeaderText = "Fullname";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Surname";
            this.Column4.HeaderText = "Surname";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Address";
            this.Column5.HeaderText = "Address";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Faculty";
            this.Column6.HeaderText = "Faculty";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Course";
            this.Column7.HeaderText = "Course";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "YearofStudy";
            this.Column8.HeaderText = "Year of study";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Room";
            this.Column9.HeaderText = "Room";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "View Full Details";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Text = "View Full Details";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsearch.BackColor = System.Drawing.Color.Transparent;
            this.btnsearch.BorderRadius = 25;
            this.btnsearch.CustomBorderColor = System.Drawing.Color.Black;
            this.btnsearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(200)))), ((int)(((byte)(248)))));
            this.btnsearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.ImageSize = new System.Drawing.Size(70, 70);
            this.btnsearch.Location = new System.Drawing.Point(755, 327);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(198, 52);
            this.btnsearch.TabIndex = 67;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseWaitCursor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnrefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnrefresh.BorderRadius = 25;
            this.btnrefresh.CustomBorderColor = System.Drawing.Color.Black;
            this.btnrefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnrefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnrefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnrefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnrefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(200)))), ((int)(((byte)(248)))));
            this.btnrefresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.White;
            this.btnrefresh.ImageSize = new System.Drawing.Size(70, 70);
            this.btnrefresh.Location = new System.Drawing.Point(981, 327);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(189, 52);
            this.btnrefresh.TabIndex = 65;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseWaitCursor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(65, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 32);
            this.label5.TabIndex = 64;
            this.label5.Text = "Search By Student Reg_no  :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "All Students Details";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label6);
            this.guna2ShadowPanel1.Controls.Add(this.label7);
            this.guna2ShadowPanel1.Controls.Add(this.panel1);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(220)))), ((int)(((byte)(243)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1283, 178);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(380, 32);
            this.label6.TabIndex = 22;
            this.label6.Text = "UNIVERSITY OF VAVUNIYA";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(363, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(535, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "HOSTEL MANAGEMENT SYSTEM FOR";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 47);
            this.panel1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1125, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 44);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1175, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 44);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::hostelloginpage.Properties.Resources.red_close_button_vector_clipart;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(1228, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 41);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtroom
            // 
            this.txtroom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtroom.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroom.Location = new System.Drawing.Point(453, 342);
            this.txtroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtroom.Name = "txtroom";
            this.txtroom.Size = new System.Drawing.Size(224, 37);
            this.txtroom.TabIndex = 5;
            // 
            // studentsDetailsBindingSource
            // 
            this.studentsDetailsBindingSource.DataMember = "StudentsDetails";
            this.studentsDetailsBindingSource.DataSource = this.hostelDBDataSet1;
            // 
            // hostelDBDataSet1
            // 
            this.hostelDBDataSet1.DataSetName = "HostelDBDataSet1";
            this.hostelDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsDetailsTableAdapter
            // 
            this.studentsDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // AllStudentdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 908);
            this.Controls.Add(this.guna2ShadowPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AllStudentdetails";
            this.Text = "AllStudentdetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AllStudentdetails_Load);
            this.guna2ShadowPanel3.ResumeLayout(false);
            this.guna2ShadowPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_studentsdetails)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnback;
        private System.Windows.Forms.DataGridView table_studentsdetails;
        private Guna.UI2.WinForms.Guna2Button btnsearch;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtroom;
        private HostelDBDataSet1 hostelDBDataSet1;
        private System.Windows.Forms.BindingSource studentsDetailsBindingSource;
        private HostelDBDataSet1TableAdapters.StudentsDetailsTableAdapter studentsDetailsTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nICnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardianNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardiancontactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floornoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}