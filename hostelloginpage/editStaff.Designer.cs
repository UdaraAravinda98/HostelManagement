﻿
namespace hostelloginpage
{
    partial class editStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editStaff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.table_staff = new System.Windows.Forms.DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnsearch = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_staff)).BeginInit();
            this.guna2ShadowPanel2.SuspendLayout();
            this.guna2ShadowPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "Edit/Delete Staff Details";
            this.label3.UseWaitCursor = true;
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmin.BackgroundImage")));
            this.btnmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.ForeColor = System.Drawing.Color.White;
            this.btnmin.Location = new System.Drawing.Point(1125, 1);
            this.btnmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(45, 44);
            this.btnmin.TabIndex = 4;
            this.btnmin.UseVisualStyleBackColor = false;
            this.btnmin.UseWaitCursor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.BackColor = System.Drawing.Color.Transparent;
            this.btnmax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmax.BackgroundImage")));
            this.btnmax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmax.ForeColor = System.Drawing.Color.White;
            this.btnmax.Location = new System.Drawing.Point(1175, 1);
            this.btnmax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(49, 44);
            this.btnmax.TabIndex = 3;
            this.btnmax.UseVisualStyleBackColor = false;
            this.btnmax.UseWaitCursor = true;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImage = global::hostelloginpage.Properties.Resources.red_close_button_vector_clipart;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Red;
            this.btnclose.Location = new System.Drawing.Point(1228, 2);
            this.btnclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(51, 41);
            this.btnclose.TabIndex = 1;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.UseWaitCursor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "UNIVERSITY OF VAVUNIYA";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "HOSTEL MANAGEMENT SYSTEM FOR";
            this.label1.UseWaitCursor = true;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.btnmin);
            this.panel5.Controls.Add(this.btnmax);
            this.panel5.Controls.Add(this.btnclose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1283, 47);
            this.panel5.TabIndex = 19;
            this.panel5.UseWaitCursor = true;
            // 
            // table_staff
            // 
            this.table_staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.name,
            this.Address,
            this.phone,
            this.FullDetails,
            this.Edit,
            this.Delete});
            this.table_staff.Location = new System.Drawing.Point(12, 395);
            this.table_staff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table_staff.Name = "table_staff";
            this.table_staff.RowHeadersWidth = 51;
            this.table_staff.RowTemplate.Height = 24;
            this.table_staff.Size = new System.Drawing.Size(1259, 229);
            this.table_staff.TabIndex = 71;
            this.table_staff.UseWaitCursor = true;
            this.table_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_staff_CellContentClick_1);
            // 
            // EmpID
            // 
            this.EmpID.DataPropertyName = "EmpId";
            this.EmpID.HeaderText = "Employee ID";
            this.EmpID.MinimumWidth = 6;
            this.EmpID.Name = "EmpID";
            // 
            // name
            // 
            this.name.DataPropertyName = "Fullname";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "Contact";
            this.phone.HeaderText = "Contact No";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            // 
            // FullDetails
            // 
            this.FullDetails.HeaderText = "Full Details";
            this.FullDetails.MinimumWidth = 6;
            this.FullDetails.Name = "FullDetails";
            this.FullDetails.Text = "View Full Details";
            this.FullDetails.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit Details";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit Details";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete Details";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete Details";
            this.Delete.UseColumnTextForButtonValue = true;
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
            this.btnsearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.ImageSize = new System.Drawing.Size(70, 70);
            this.btnsearch.Location = new System.Drawing.Point(917, 324);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(160, 49);
            this.btnsearch.TabIndex = 70;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseWaitCursor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(324, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 32);
            this.label5.TabIndex = 69;
            this.label5.Text = "Search By Employee ID :";
            this.label5.UseWaitCursor = true;
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtid.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(661, 322);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(224, 37);
            this.txtid.TabIndex = 68;
            this.txtid.UseWaitCursor = true;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.label2);
            this.guna2ShadowPanel2.Controls.Add(this.label1);
            this.guna2ShadowPanel2.Controls.Add(this.panel5);
            this.guna2ShadowPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(220)))), ((int)(((byte)(243)))));
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 5;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(1283, 178);
            this.guna2ShadowPanel2.TabIndex = 0;
            this.guna2ShadowPanel2.UseWaitCursor = true;
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.AutoScroll = true;
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.btnrefresh);
            this.guna2ShadowPanel3.Controls.Add(this.table_staff);
            this.guna2ShadowPanel3.Controls.Add(this.btnsearch);
            this.guna2ShadowPanel3.Controls.Add(this.label5);
            this.guna2ShadowPanel3.Controls.Add(this.txtid);
            this.guna2ShadowPanel3.Controls.Add(this.guna2GradientTileButton1);
            this.guna2ShadowPanel3.Controls.Add(this.guna2ShadowPanel2);
            this.guna2ShadowPanel3.Controls.Add(this.label3);
            this.guna2ShadowPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(1283, 703);
            this.guna2ShadowPanel3.TabIndex = 4;
            this.guna2ShadowPanel3.UseWaitCursor = true;
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
            this.btnrefresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.White;
            this.btnrefresh.ImageSize = new System.Drawing.Size(70, 70);
            this.btnrefresh.Location = new System.Drawing.Point(1103, 325);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(152, 48);
            this.btnrefresh.TabIndex = 73;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseWaitCursor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // guna2GradientTileButton1
            // 
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
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(12, 196);
            this.guna2GradientTileButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(115, 58);
            this.guna2GradientTileButton1.TabIndex = 8;
            this.guna2GradientTileButton1.UseWaitCursor = true;
            this.guna2GradientTileButton1.Click += new System.EventHandler(this.guna2GradientTileButton1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.guna2ShadowPanel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1283, 703);
            this.panel6.TabIndex = 15;
            this.panel6.UseWaitCursor = true;
            // 
            // editStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1283, 703);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "editStaff";
            this.Text = "editStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.editStaff_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_staff)).EndInit();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.guna2ShadowPanel3.ResumeLayout(false);
            this.guna2ShadowPanel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView table_staff;
        private Guna.UI2.WinForms.Guna2Button btnsearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtid;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewButtonColumn FullDetails;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}