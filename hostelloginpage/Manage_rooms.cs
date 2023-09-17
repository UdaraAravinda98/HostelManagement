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
    public partial class Manage_rooms : Form
    {

        

        public Manage_rooms()
        {
            InitializeComponent();
        }
       

        private void Manage_rooms_Load(object sender, EventArgs e)
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
            ManageStudent mngstudent = new ManageStudent();
            mngstudent.Show();
        }

        private void btn_manageroom_Click(object sender, EventArgs e)
        {
            this.Show();
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

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frontpage frnpage = new frontpage();
            frnpage.Show();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstFloor first = new FirstFloor();
            first.Show();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Secondfloor second = new Secondfloor();
            second.Show();
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thirdfloor third = new Thirdfloor();
            third.Show();
        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fourthfloor fourth = new Fourthfloor();
            fourth.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            aboutus about = new aboutus();
            about.Show();
        }

        private void guna2GradientTileButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            contact con = new contact();
            con.Show();
        }
    }
}
