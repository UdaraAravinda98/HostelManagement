using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace hostelloginpage
{
    public partial class ExcelToSql : Form
    {
        public ExcelToSql()
        {
            InitializeComponent();
        }

        DataTableCollection tableCollection;

        private void btnselect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog =new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtfilename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using(IExcelDataReader reader =ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });

                            tableCollection = result.Tables;
                            cmbselect.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cmbselect.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void cmbselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cmbselect.SelectedItem.ToString()];
           if(dt != null)
            {
                List<ReadExcel> student = new List<ReadExcel>();
                for(int i =0; i<dt.Rows.Count;i++)
                {
                 
                    ReadExcel Readexl = new ReadExcel();
                    Readexl.Regno = dt.Rows[i]["University Registration No"].ToString();
                    Readexl.Fullname = dt.Rows[i]["Full Name "].ToString();
                    Readexl.Surname = dt.Rows[i]["Sur Name"].ToString();
                    Readexl.Address = dt.Rows[i]["Residential Address"].ToString();
                    Readexl.District = dt.Rows[i]["Residential District"].ToString();
                    Readexl.GSdivision = dt.Rows[i]["GS Division"].ToString();
                    Readexl.DSdivision = dt.Rows[i]["DS Division"].ToString();
                    Readexl.Sex = dt.Rows[i]["Sex"].ToString();
                    Readexl.NICno = dt.Rows[i]["NIC Number "].ToString();
                    Readexl.DOB = dt.Rows[i]["Date Of Birth"].ToString();
                    Readexl.Faculty = dt.Rows[i]["Faculty"].ToString();
                    Readexl.Course = dt.Rows[i]["Course Of Study"].ToString();
                    Readexl.Yearofstudy = dt.Rows[i]["Year Of Study"].ToString();
                    Readexl.Contact = dt.Rows[i]["Contact "].ToString();
                    Readexl.Email = dt.Rows[i]["E-mail ID"].ToString();
                    Readexl.Medicalhistory = dt.Rows[i]["Whether the candidate has any medical history of Ailments  "].ToString();
                    Readexl.Guardianname = dt.Rows[i]["Person to Contact to Case of Emergency Name "].ToString();
                    Readexl.Guardianrelationship = dt.Rows[i]["Relationship"].ToString();
                    Readexl.GuardianAddress = dt.Rows[i]["Address"].ToString();
                    Readexl.Guardiancontact = dt.Rows[i]["Phone Number "].ToString();
                    Readexl.Nearbypolice = dt.Rows[i]["Police Station Near By Your Home Town"].ToString();
                    student.Add(Readexl);

                }
                dataGridView1.DataSource = student;
            }
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True";
                DapperPlusManager.Entity<ReadExcel>().Table("Student");
                List<ReadExcel> student = dataGridView1.DataSource as List<ReadExcel>;
                if(student != null )
                {
                    using (IDbConnection db = new SqlConnection(connectionstring))
                    {
                        db.BulkInsert(student);
                    }
                }
                MessageBox.Show("Successfully Import!!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
