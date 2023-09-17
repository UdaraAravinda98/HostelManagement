
namespace hostelloginpage
{
    partial class living
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(living));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chairs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtroom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.living_status_label = new System.Windows.Forms.Label();
            this.table_liveStatus = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnsearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_liveStatus)).BeginInit();
            this.guna2ShadowPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Active State";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col
            // 
            this.col.DataPropertyName = "Room";
            this.col.HeaderText = "Room No";
            this.col.MinimumWidth = 6;
            this.col.Name = "col";
            this.col.ReadOnly = true;
            this.col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // chairs
            // 
            this.chairs.DataPropertyName = "NICno";
            this.chairs.HeaderText = "NIC";
            this.chairs.MinimumWidth = 6;
            this.chairs.Name = "chairs";
            this.chairs.ReadOnly = true;
            this.chairs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Sex";
            this.Column3.HeaderText = "Gender";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // column6
            // 
            this.column6.DataPropertyName = "Address";
            this.column6.HeaderText = "Address";
            this.column6.MinimumWidth = 15;
            this.column6.Name = "column6";
            this.column6.ReadOnly = true;
            this.column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // column5
            // 
            this.column5.DataPropertyName = "Fullname";
            this.column5.HeaderText = "Name";
            this.column5.MinimumWidth = 6;
            this.column5.Name = "column5";
            this.column5.ReadOnly = true;
            this.column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Floor
            // 
            this.Floor.DataPropertyName = "Regno";
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.LightGray;
            this.Floor.DefaultCellStyle = dataGridViewCellStyle13;
            this.Floor.HeaderText = "Reg No";
            this.Floor.MinimumWidth = 10;
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            this.Floor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(94, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 32);
            this.label5.TabIndex = 73;
            this.label5.Text = "Search By Student Reg_no  :";
            // 
            // txtroom
            // 
            this.txtroom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtroom.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroom.Location = new System.Drawing.Point(482, 324);
            this.txtroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtroom.Name = "txtroom";
            this.txtroom.Size = new System.Drawing.Size(224, 37);
            this.txtroom.TabIndex = 72;
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
            this.button1.Location = new System.Drawing.Point(1137, 1);
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
            this.button2.Location = new System.Drawing.Point(1186, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 44);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.btnrefresh.Location = new System.Drawing.Point(1010, 309);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(189, 52);
            this.btnrefresh.TabIndex = 74;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseWaitCursor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
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
            this.button3.Location = new System.Drawing.Point(1239, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 41);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ContactNo";
            this.Column7.HeaderText = "Contact";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(631, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "UNIVERSITY OF VAVUNIYA";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(535, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "HOSTEL MANAGEMENT SYSTEM FOR";
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 47);
            this.panel1.TabIndex = 19;
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.guna2GradientTileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientTileButton1.Image")));
            this.guna2GradientTileButton1.ImageSize = new System.Drawing.Size(80, 80);
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(22, 184);
            this.guna2GradientTileButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(115, 58);
            this.guna2GradientTileButton1.TabIndex = 71;
            this.guna2GradientTileButton1.UseWaitCursor = true;
            this.guna2GradientTileButton1.Click += new System.EventHandler(this.guna2GradientTileButton1_Click);
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.label3);
            this.guna2ShadowPanel2.Controls.Add(this.label4);
            this.guna2ShadowPanel2.Controls.Add(this.panel1);
            this.guna2ShadowPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(220)))), ((int)(((byte)(243)))));
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 5;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(1293, 179);
            this.guna2ShadowPanel2.TabIndex = 0;
            // 
            // living_status_label
            // 
            this.living_status_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.living_status_label.AutoSize = true;
            this.living_status_label.BackColor = System.Drawing.Color.Transparent;
            this.living_status_label.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.living_status_label.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.living_status_label.Location = new System.Drawing.Point(14, 247);
            this.living_status_label.Name = "living_status_label";
            this.living_status_label.Size = new System.Drawing.Size(388, 43);
            this.living_status_label.TabIndex = 1;
            this.living_status_label.Text = "Students Living Status";
            this.living_status_label.UseWaitCursor = true;
            // 
            // table_liveStatus
            // 
            this.table_liveStatus.AllowUserToAddRows = false;
            this.table_liveStatus.AllowUserToDeleteRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            this.table_liveStatus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.table_liveStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_liveStatus.BackgroundColor = System.Drawing.Color.DarkGray;
            this.table_liveStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.table_liveStatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_liveStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.table_liveStatus.ColumnHeadersHeight = 59;
            this.table_liveStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.table_liveStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Floor,
            this.column5,
            this.column6,
            this.Column3,
            this.chairs,
            this.col,
            this.Column7,
            this.Column1});
            this.table_liveStatus.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_liveStatus.DefaultCellStyle = dataGridViewCellStyle16;
            this.table_liveStatus.EnableHeadersVisualStyles = true;
            this.table_liveStatus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_liveStatus.Location = new System.Drawing.Point(14, 393);
            this.table_liveStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table_liveStatus.Name = "table_liveStatus";
            this.table_liveStatus.ReadOnly = true;
            this.table_liveStatus.RowHeadersVisible = false;
            this.table_liveStatus.RowHeadersWidth = 51;
            this.table_liveStatus.RowTemplate.Height = 24;
            this.table_liveStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.table_liveStatus.ShowRowErrors = false;
            this.table_liveStatus.Size = new System.Drawing.Size(1267, 266);
            this.table_liveStatus.TabIndex = 70;
            this.table_liveStatus.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.table_liveStatus.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.table_liveStatus.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.table_liveStatus.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.table_liveStatus.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.table_liveStatus.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.table_liveStatus.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_liveStatus.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.table_liveStatus.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.table_liveStatus.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_liveStatus.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.table_liveStatus.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.table_liveStatus.ThemeStyle.HeaderStyle.Height = 59;
            this.table_liveStatus.ThemeStyle.ReadOnly = true;
            this.table_liveStatus.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.table_liveStatus.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table_liveStatus.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_liveStatus.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.table_liveStatus.ThemeStyle.RowsStyle.Height = 24;
            this.table_liveStatus.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_liveStatus.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btnsearch.Location = new System.Drawing.Point(784, 309);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(198, 52);
            this.btnsearch.TabIndex = 75;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseWaitCursor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2ShadowPanel3.BackgroundImage")));
            this.guna2ShadowPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2ShadowPanel3.Controls.Add(this.btnsearch);
            this.guna2ShadowPanel3.Controls.Add(this.btnrefresh);
            this.guna2ShadowPanel3.Controls.Add(this.label5);
            this.guna2ShadowPanel3.Controls.Add(this.txtroom);
            this.guna2ShadowPanel3.Controls.Add(this.guna2GradientTileButton1);
            this.guna2ShadowPanel3.Controls.Add(this.guna2ShadowPanel2);
            this.guna2ShadowPanel3.Controls.Add(this.living_status_label);
            this.guna2ShadowPanel3.Controls.Add(this.table_liveStatus);
            this.guna2ShadowPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(1293, 670);
            this.guna2ShadowPanel3.TabIndex = 73;
            // 
            // living
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 670);
            this.Controls.Add(this.guna2ShadowPanel3);
            this.Name = "living";
            this.Text = "living";
            this.Load += new System.EventHandler(this.living_Load);
            this.panel1.ResumeLayout(false);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_liveStatus)).EndInit();
            this.guna2ShadowPanel3.ResumeLayout(false);
            this.guna2ShadowPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private System.Windows.Forms.DataGridViewTextBoxColumn chairs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtroom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private System.Windows.Forms.Label living_status_label;
        private Guna.UI2.WinForms.Guna2DataGridView table_liveStatus;
        private Guna.UI2.WinForms.Guna2Button btnsearch;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
    }
}