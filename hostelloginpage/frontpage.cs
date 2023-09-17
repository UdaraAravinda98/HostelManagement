using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostelloginpage
{
    public partial class frontpage : Form
    {

        public frontpage()
        {
            InitializeComponent();
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

        private void frontpage_Load(object sender, EventArgs e)
        {

        }

        

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_newstudent_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            NewStudent student = new NewStudent();
            student.Show();
        }

        private void btn_mngstudent_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ManageStudent Managestu = new ManageStudent();
            Managestu.Show();
        }

        private void btn_manageroom_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Manage_rooms mnsroom = new Manage_rooms();
            mnsroom.Show();
        }

        private void btn_manageassert_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ManageAsserts mngass = new ManageAsserts();
            mngass.Show();
        }

        private void btn_managestaff_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Managestaff mngstf = new Managestaff();
            mngstf.Show();
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SentUrlmail sent = new SentUrlmail();
            sent.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mailbox mail = new Mailbox();
            mail.ShowDialog();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            contact con = new contact();
            con.Show();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            aboutus about =new aboutus();
            about.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
