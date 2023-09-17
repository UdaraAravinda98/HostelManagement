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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }



        private void txtusername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtusername.Text == "Username")
            {
                txtusername.Clear();
            }
        }

        private void txtpassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Clear();
                txtpassword.PasswordChar = '*';
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection();
        }

        private void DBConnection()
        {
            
            string query = "SELECT * FROM UserRegister where User_name ='" + txtusername.Text + "' AND Password ='" + txtpassword.Text + "'";

            SqlConnection DBConnect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
            SqlCommand commandDatabase = new SqlCommand(query, DBConnect);
            commandDatabase.CommandTimeout = 60;
            SqlDataReader reader;

            try
            {
                DBConnect.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.Hide();
                        frontpage frnpage = new frontpage();
                        frnpage.Show();
                    }
                }
                else
                {
                    MessageBox.Show("You enter invalid user name or password try again !!!");
                }
                DBConnect.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup frm3 = new Signup();
            frm3.Show();

        }

        
        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
           
        }


        private void btnforgot_Click(object sender, EventArgs e)
        {
            Forgotpassword forgot = new Forgotpassword();
            this.Hide();
            forgot.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }




}
