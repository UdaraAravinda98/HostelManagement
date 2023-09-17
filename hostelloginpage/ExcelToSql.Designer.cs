
namespace hostelloginpage
{
    partial class ExcelToSql
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbselect = new System.Windows.Forms.ComboBox();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnimport = new System.Windows.Forms.Button();
            this.hostelDBDataSet1 = new hostelloginpage.HostelDBDataSet1();
            this.hostelDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new hostelloginpage.HostelDBDataSet1TableAdapters.TableTableAdapter();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userRegisterTableAdapter = new hostelloginpage.HostelDBDataSet1TableAdapters.UserRegisterTableAdapter();
            this.btnremove = new System.Windows.Forms.Button();
            this.regnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSdivisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSdivisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nICnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearofstudyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalhistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardiannameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardianrelationshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardianAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardiancontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nearbypoliceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readExcelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excelToSqlBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.functionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excelToSqlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readExcelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelToSqlBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelToSqlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regnoDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.gSdivisionDataGridViewTextBoxColumn,
            this.dSdivisionDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.nICnoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.facultyDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.yearofstudyDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.medicalhistoryDataGridViewTextBoxColumn,
            this.guardiannameDataGridViewTextBoxColumn,
            this.guardianrelationshipDataGridViewTextBoxColumn,
            this.guardianAddressDataGridViewTextBoxColumn,
            this.guardiancontactDataGridViewTextBoxColumn,
            this.nearbypoliceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.readExcelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1070, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select File Name :";
            // 
            // cmbselect
            // 
            this.cmbselect.FormattingEnabled = true;
            this.cmbselect.Location = new System.Drawing.Point(170, 529);
            this.cmbselect.Name = "cmbselect";
            this.cmbselect.Size = new System.Drawing.Size(680, 24);
            this.cmbselect.TabIndex = 3;
            this.cmbselect.SelectedIndexChanged += new System.EventHandler(this.cmbselect_SelectedIndexChanged);
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(170, 481);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(680, 22);
            this.txtfilename.TabIndex = 4;
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(866, 480);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(43, 23);
            this.btnselect.TabIndex = 5;
            this.btnselect.Text = "...";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Sheet :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(601, 570);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(172, 32);
            this.btnimport.TabIndex = 7;
            this.btnimport.Text = "Import";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // hostelDBDataSet1
            // 
            this.hostelDBDataSet1.DataSetName = "HostelDBDataSet1";
            this.hostelDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hostelDBDataSet1BindingSource
            // 
            this.hostelDBDataSet1BindingSource.DataSource = this.hostelDBDataSet1;
            this.hostelDBDataSet1BindingSource.Position = 0;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.hostelDBDataSet1;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.hostelDBDataSet1BindingSource;
            // 
            // userRegisterBindingSource
            // 
            this.userRegisterBindingSource.DataMember = "UserRegister";
            this.userRegisterBindingSource.DataSource = this.hostelDBDataSet1BindingSource;
            // 
            // userRegisterTableAdapter
            // 
            this.userRegisterTableAdapter.ClearBeforeFill = true;
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(233, 570);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(190, 32);
            this.btnremove.TabIndex = 8;
            this.btnremove.Text = "Back";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // regnoDataGridViewTextBoxColumn
            // 
            this.regnoDataGridViewTextBoxColumn.DataPropertyName = "Regno";
            this.regnoDataGridViewTextBoxColumn.HeaderText = "Regno";
            this.regnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regnoDataGridViewTextBoxColumn.Name = "regnoDataGridViewTextBoxColumn";
            this.regnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "District";
            this.districtDataGridViewTextBoxColumn.HeaderText = "District";
            this.districtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            this.districtDataGridViewTextBoxColumn.Width = 125;
            // 
            // gSdivisionDataGridViewTextBoxColumn
            // 
            this.gSdivisionDataGridViewTextBoxColumn.DataPropertyName = "GSdivision";
            this.gSdivisionDataGridViewTextBoxColumn.HeaderText = "GSdivision";
            this.gSdivisionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gSdivisionDataGridViewTextBoxColumn.Name = "gSdivisionDataGridViewTextBoxColumn";
            this.gSdivisionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dSdivisionDataGridViewTextBoxColumn
            // 
            this.dSdivisionDataGridViewTextBoxColumn.DataPropertyName = "DSdivision";
            this.dSdivisionDataGridViewTextBoxColumn.HeaderText = "DSdivision";
            this.dSdivisionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dSdivisionDataGridViewTextBoxColumn.Name = "dSdivisionDataGridViewTextBoxColumn";
            this.dSdivisionDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 125;
            // 
            // nICnoDataGridViewTextBoxColumn
            // 
            this.nICnoDataGridViewTextBoxColumn.DataPropertyName = "NICno";
            this.nICnoDataGridViewTextBoxColumn.HeaderText = "NICno";
            this.nICnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nICnoDataGridViewTextBoxColumn.Name = "nICnoDataGridViewTextBoxColumn";
            this.nICnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.Width = 125;
            // 
            // facultyDataGridViewTextBoxColumn
            // 
            this.facultyDataGridViewTextBoxColumn.DataPropertyName = "Faculty";
            this.facultyDataGridViewTextBoxColumn.HeaderText = "Faculty";
            this.facultyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facultyDataGridViewTextBoxColumn.Name = "facultyDataGridViewTextBoxColumn";
            this.facultyDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearofstudyDataGridViewTextBoxColumn
            // 
            this.yearofstudyDataGridViewTextBoxColumn.DataPropertyName = "Yearofstudy";
            this.yearofstudyDataGridViewTextBoxColumn.HeaderText = "Yearofstudy";
            this.yearofstudyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearofstudyDataGridViewTextBoxColumn.Name = "yearofstudyDataGridViewTextBoxColumn";
            this.yearofstudyDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicalhistoryDataGridViewTextBoxColumn
            // 
            this.medicalhistoryDataGridViewTextBoxColumn.DataPropertyName = "Medicalhistory";
            this.medicalhistoryDataGridViewTextBoxColumn.HeaderText = "Medicalhistory";
            this.medicalhistoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicalhistoryDataGridViewTextBoxColumn.Name = "medicalhistoryDataGridViewTextBoxColumn";
            this.medicalhistoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // guardiannameDataGridViewTextBoxColumn
            // 
            this.guardiannameDataGridViewTextBoxColumn.DataPropertyName = "Guardianname";
            this.guardiannameDataGridViewTextBoxColumn.HeaderText = "Guardianname";
            this.guardiannameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guardiannameDataGridViewTextBoxColumn.Name = "guardiannameDataGridViewTextBoxColumn";
            this.guardiannameDataGridViewTextBoxColumn.Width = 125;
            // 
            // guardianrelationshipDataGridViewTextBoxColumn
            // 
            this.guardianrelationshipDataGridViewTextBoxColumn.DataPropertyName = "Guardianrelationship";
            this.guardianrelationshipDataGridViewTextBoxColumn.HeaderText = "Guardianrelationship";
            this.guardianrelationshipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guardianrelationshipDataGridViewTextBoxColumn.Name = "guardianrelationshipDataGridViewTextBoxColumn";
            this.guardianrelationshipDataGridViewTextBoxColumn.Width = 125;
            // 
            // guardianAddressDataGridViewTextBoxColumn
            // 
            this.guardianAddressDataGridViewTextBoxColumn.DataPropertyName = "GuardianAddress";
            this.guardianAddressDataGridViewTextBoxColumn.HeaderText = "GuardianAddress";
            this.guardianAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guardianAddressDataGridViewTextBoxColumn.Name = "guardianAddressDataGridViewTextBoxColumn";
            this.guardianAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // guardiancontactDataGridViewTextBoxColumn
            // 
            this.guardiancontactDataGridViewTextBoxColumn.DataPropertyName = "Guardiancontact";
            this.guardiancontactDataGridViewTextBoxColumn.HeaderText = "Guardiancontact";
            this.guardiancontactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guardiancontactDataGridViewTextBoxColumn.Name = "guardiancontactDataGridViewTextBoxColumn";
            this.guardiancontactDataGridViewTextBoxColumn.Width = 125;
            // 
            // nearbypoliceDataGridViewTextBoxColumn
            // 
            this.nearbypoliceDataGridViewTextBoxColumn.DataPropertyName = "Nearbypolice";
            this.nearbypoliceDataGridViewTextBoxColumn.HeaderText = "Nearbypolice";
            this.nearbypoliceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nearbypoliceDataGridViewTextBoxColumn.Name = "nearbypoliceDataGridViewTextBoxColumn";
            this.nearbypoliceDataGridViewTextBoxColumn.Width = 125;
            // 
            // readExcelBindingSource
            // 
            this.readExcelBindingSource.DataSource = typeof(hostelloginpage.ReadExcel);
            // 
            // excelToSqlBindingSource1
            // 
            this.excelToSqlBindingSource1.DataSource = typeof(hostelloginpage.ExcelToSql);
            // 
            // functionBindingSource
            // 
            this.functionBindingSource.DataSource = typeof(hostelloginpage.function);
            // 
            // excelToSqlBindingSource
            // 
            this.excelToSqlBindingSource.DataSource = typeof(hostelloginpage.ExcelToSql);
            // 
            // ExcelToSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1133, 614);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.cmbselect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExcelToSql";
            this.Text = "ExcelToSql";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readExcelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelToSqlBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelToSqlBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbselect;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.BindingSource hostelDBDataSet1BindingSource;
        private HostelDBDataSet1 hostelDBDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private HostelDBDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.BindingSource functionBindingSource;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private System.Windows.Forms.BindingSource userRegisterBindingSource;
        private HostelDBDataSet1TableAdapters.UserRegisterTableAdapter userRegisterTableAdapter;
        private System.Windows.Forms.BindingSource excelToSqlBindingSource1;
        private System.Windows.Forms.BindingSource excelToSqlBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSdivisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSdivisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nICnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearofstudyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalhistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardiannameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardianrelationshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardianAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardiancontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nearbypoliceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource readExcelBindingSource;
        private System.Windows.Forms.Button btnremove;
    }
}