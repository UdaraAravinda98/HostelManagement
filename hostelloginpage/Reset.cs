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
    public partial class Reset : Form
    {
        String Email = Forgotpassword.to;

        public Reset()
        {
            InitializeComponent();
            this.ActiveControl = txtpassvarify;
            txtpassvarify.Focus();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            if ( Txtpass.Text == txtpassvarify.Text)
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[UserRegister] SET [Password] = '" + txtpassvarify.Text + "' WHERE Email = '" + Email + "'  ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Txtpass.Text = "";
                txtpassvarify.Text = "";
                MessageBox.Show("Reset Successfully");

            }
            else
            {
                MessageBox.Show("The New Password Is Not Match so enter same password");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forgotpassword forgot = new Forgotpassword();
            this.Hide();
            forgot.Show();
        }

        private void Txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpassvarify.Focus();
            }
           
        }

        private void txtpassvarify_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnreset.PerformClick();
            }
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmax_Click(object sender, EventArgs e)
        {

        }

        

        private void Reset_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmax_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnmin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
