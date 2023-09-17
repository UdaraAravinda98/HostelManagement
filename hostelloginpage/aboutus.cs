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
    public partial class aboutus : Form
    {
        public aboutus()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        /*private void btnback_contactus_Click(object sender, EventArgs e)
        {

        }*/

        private void btnback_aboutus_Click(object sender, EventArgs e)
        {
            this.Hide();
            frontpage frnpage = new frontpage();
            frnpage.Show();
        }

        private void txtAboutUs_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void aboutus_Load(object sender, EventArgs e)
        {
            
        }
    }
}
