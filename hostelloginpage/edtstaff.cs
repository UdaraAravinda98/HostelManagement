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
    
    public partial class edtstaff : Form
    {
        string employee1;
        public edtstaff(string employee)
        {
            InitializeComponent();
            employee1 = employee;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            editStaff edtstf = new editStaff();
            edtstf.Show();
        }

        private void edtstaff_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
            Con.Open();
            string query = "Select * from StaffDetails where empid=@emplid";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@emplid", employee1);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                txtid.Text = da.GetValue(0).ToString();
                txtname.Text = da.GetValue(1).ToString();
                txtadrs.Text = da.GetValue(2).ToString();
                txtCat.Text = da.GetValue(3).ToString();
                txtDate.Text = da.GetValue(4).ToString();
                txtSex.Text = da.GetValue(5).ToString();
                txtnic.Text = da.GetValue(6).ToString();
                txtdob.Text = da.GetValue(7).ToString();
                txtno.Text = da.GetValue(8).ToString();
                txtemail.Text = da.GetValue(9).ToString();
                txtemname.Text = da.GetValue(10).ToString();
                txtemadrs.Text = da.GetValue(11).ToString();
                txtemno.Text = da.GetValue(12).ToString();
                txtemrel.Text = da.GetValue(13).ToString();
            }
            Con.Close();
            txtempid.Text = employee1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id1 = txtid.Text;
            string name1 = txtname.Text;
            string adrs1 = txtadrs.Text;
            string cat1 = txtCat.Text;
            string date1 = txtDate.Text;
            string sex1 = txtSex.Text;
            string nic1 = txtnic.Text;
            string dob1 = txtdob.Text;
            string no1 = txtno.Text;
            string email1 = txtemail.Text;
            string emname1 = txtemname.Text;
            string emno1 = txtemno.Text;
            string emrel1= txtemrel.Text;
            string emadrs1 = txtemadrs.Text;

            SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
            Con.Open();
            try
            {
                string query = "UPDATE StaffDetails SET EmpID=@EmpId, Fullname=@Fullname, Address=@Address, Category=@Category, Joined=@Joined,Sex=@Sex, NIC=@NIC, DOB=@DOB, Contact=@Contact, Email=@Email,EmName=@EmName, EmAddress=@EmAddress,EmPhone=@EmPhone, EmRel=@EmRel where EmpID=@Emp" ;
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@EmpId",id1);
                cmd.Parameters.AddWithValue("@Fullname",name1);
                cmd.Parameters.AddWithValue("@Address",adrs1);
                cmd.Parameters.AddWithValue("@Category",cat1);
                cmd.Parameters.AddWithValue("@Joined",date1);
                cmd.Parameters.AddWithValue("@Sex",sex1);
                cmd.Parameters.AddWithValue("@NIC",nic1);
                cmd.Parameters.AddWithValue("@DOB",dob1);
                cmd.Parameters.AddWithValue("@Contact",no1);
                cmd.Parameters.AddWithValue("@Email",email1);
                cmd.Parameters.AddWithValue("@EmName",emname1);
                cmd.Parameters.AddWithValue("@EmAddress",emadrs1);
                cmd.Parameters.AddWithValue("@EmPhone",emno1);
                cmd.Parameters.AddWithValue("@EmRel",emrel1);
                cmd.Parameters.AddWithValue("@Emp", employee1);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data Updated Successfull.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data Not Updated");
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

        private void txtempid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
