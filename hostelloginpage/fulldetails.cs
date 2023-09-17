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
    public partial class fulldetails : Form
    {
       
        string employee1;
        
        public fulldetails(string employee)
        {
            InitializeComponent();
            employee1 = employee;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void fulldetails_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
            Con.Open();
            string query = "Select * from StaffDetails where empid=@emplid";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@emplid", employee1);
            SqlDataReader da = cmd.ExecuteReader();
            while(da.Read())
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

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void txtemadrs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
