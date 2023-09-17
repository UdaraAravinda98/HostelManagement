using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hostelloginpage
{
    public partial class Addstaff : Form
    {
        string query;
        function fun = new function();
        public Addstaff()
        {
            InitializeComponent();
        }

        private void Addstaff_Load(object sender, EventArgs e)
        {

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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "" && txtname.Text != "" && txtadrs.Text != "" && cmbcat.SelectedItem != "" && txtDate.Text != "" && cmbsex.SelectedItem != "" && txtnic.Text != ""
                && txtdob.Text != "" && txtno.Text != "" && txtemail.Text != "" && txtemname.Text != "" && txtemadrs.Text != "" && txtemno.Text != "" && txtemrel.Text != "")
            {
               // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HostelDB.mdf;Integrated Security=True");
               // SqlCommand cmd = new SqlCommand("INSERT INTO[dbo].[StaffDetails] VALUES ('" + txtid.Text + "','" + txtname.Text + "','" + txtadrs.Text + "','" + cmbcat.SelectedItem + "','" + txtDate.Text + "','" + cmbsex.SelectedItem + "','" + txtnic.Text + "','" + txtdob.Text + "','" + txtno.Text + "','" + txtemail.Text + "','" + txtemname.Text + "','" + txtemadrs.Text + "','" + txtemno.Text + "','" + txtemrel.Text + "')", con);
                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();
                //MessageBox.Show("Staff Added Successfully!");

                query= "insert into StaffDetails(EmpId,Fullname,Address,Category,Joined,Sex,NIC,DOB,Contact,Email,EmName,EmAddress,EmPhone,EmRel) values ('" + txtid.Text + "','" + txtname.Text + "','" + txtadrs.Text + "','" + cmbcat.SelectedItem + "','" + txtDate.Text + "','" + cmbsex.SelectedItem + "','" + txtnic.Text + "','" + txtdob.Text + "','" + txtno.Text + "','" + txtemail.Text + "','" + txtemname.Text + "','" + txtemadrs.Text + "','" + txtemno.Text + "','" + txtemrel.Text + "')";
                fun.setData(query, "Staff  Details Added.");

                txtid.Text = "";
                txtname.Text = "";
                txtadrs.Text = "";
                cmbcat.SelectedItem = string.Empty;
                txtDate.Text = "";
                cmbsex.SelectedItem = string.Empty;
                txtnic.Text = "";
                txtdob.Text = "";
                txtno.Text = "";
                txtemail.Text = "";
                txtemname.Text = "";
                txtemadrs.Text = "";
                txtemno.Text = "";
                txtemrel.Text = "";
            }
            else
            {
                MessageBox.Show("Fill All fields", "Warning !! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
