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
    public partial class ManageStudent : Form
    {

        public ManageStudent()
        {
            InitializeComponent();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnmin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        

        

       

        private void btn_mngestudent_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       
        private void ManageStudent_Load_1(object sender, EventArgs e)
        {
          
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllStudentdetails studet = new AllStudentdetails();
            studet.Show();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditStudentDetails editStuDet = new EditStudentDetails();
            editStuDet.Show();
        }

        private void btn_newstudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewStudent student = new NewStudent();
            student.Show();
        }

        private void btn_mngstudent_Click(object sender, EventArgs e)
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

        private void btnclose_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmax_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnmin_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frontpage frnpage = new frontpage();
            frnpage.Show();
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            living liv = new living();
            liv.Show();
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
