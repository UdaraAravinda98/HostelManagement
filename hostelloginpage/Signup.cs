using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace hostelloginpage
{
    public partial class Signup : Form
    {

        

        public Signup()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void txtinsname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcontact.Focus();
            }
        }



        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            
            

            if (!this.txtEmail.Text.Contains('@') || !this.txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPassword.Text != TxtConPassword.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }

            if (string.IsNullOrEmpty(txtinsname.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtcontact.Text) || string.IsNullOrEmpty(txtcreatername.Text) || string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(TxtConPassword.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[UserRegister]
           ([Institude_name]
           ,[Email]
           ,[Contact]
           ,[Creater_name]
           ,[User_name]
           ,[Password]
           ,[ConPassword])
     VALUES
           ('" + txtinsname.Text + "','" + txtEmail.Text + "','" + txtcontact.Text + "','" + txtcreatername.Text + "','" + txtusername.Text + "','" + txtPassword.Text + "','" + TxtConPassword.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

                    MessageBox.Show("Account Successfully Created!");
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    this.Hide();
                }

                


        }
        

       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void txtcontact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcreatername.Focus();
            }
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtcreatername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtusername.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtConPassword.Focus();
            }
        }

        private void TxtConPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btsubmit.PerformClick();
            }
        }

        private void Signup_Load(object sender, EventArgs e)
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
    }
}
