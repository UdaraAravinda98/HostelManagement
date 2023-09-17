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
    public partial class ManageAsserts : Form
    {

       

        public ManageAsserts()
        {
            InitializeComponent();
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
            this.Show();
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
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

        private void btn_managestaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Managestaff mngstf = new Managestaff();
            mngstf.Show();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frontpage frnpage = new frontpage();
            frnpage.Show();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Roomdetails details = new Roomdetails();
            details.Show();

        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditAsserts editass = new EditAsserts();
            editass.Show();
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteroom delete = new deleteroom();
            delete.Show();
        }

        private void ManageAsserts_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            aboutus about = new aboutus();
            about.Show();
        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            contact con = new contact();
            con.Show();
        }
    }
}
