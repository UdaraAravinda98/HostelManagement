using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hostelloginpage
{
    public partial class editStaff : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
        public editStaff()
        {
            InitializeComponent();
        }

        public void TextboxFilter()
        {
            Con.Open();
            string query = "select EmpId,Fullname,Address,Contact from StaffDetails where EmpId='" + txtid.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            table_staff.DataSource = ds.Tables[0];
            Con.Close();

        }

        public void populateGrid()
        {
            Con.Open();
            string query = "select EmpId,Fullname,Address,Contact from StaffDetails";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            table_staff.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Managestaff mngstf = new Managestaff();
            mngstf.Show();
        }

        private void editStaff_Load(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            populateGrid();
            txtid.Text = "";
        }

       

        private void table_asserts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }

        private void table_staff_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (table_staff.Columns[e.ColumnIndex].HeaderText == "Full Details")
            {

                string employee;
                employee = Convert.ToString(table_staff.Rows[e.RowIndex].Cells["EmpId"].Value);
                fulldetails det = new fulldetails(employee);
                det.ShowDialog();

            }
            else if (table_staff.Columns[e.ColumnIndex].HeaderText == "Edit Details")
            {

                string employee;
                employee = Convert.ToString(table_staff.Rows[e.RowIndex].Cells["EmpId"].Value);
                edtstaff det = new edtstaff(employee);
                det.ShowDialog();

            }
            else if (table_staff.Columns[e.ColumnIndex].HeaderText == "Delete Details")
            {
                Con.Open();
                try
                {
                    string employee;
                    employee = Convert.ToString(table_staff.Rows[e.RowIndex].Cells["EmpId"].Value);

                    string query = "DELETE FROM StaffDetails WHERE  EmpId=@Emp";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@Emp", employee);
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Room Deleted Successfull");
                    }
                    else
                    {
                        MessageBox.Show("Data Not Deleted");

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
