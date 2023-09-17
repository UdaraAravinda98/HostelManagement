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
    public partial class living : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");

        public living()
        {
            InitializeComponent();
        }

        public void populateGrid()
        {
            Con.Open();
            string query = "select * from StuDetails";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            table_liveStatus.DataSource = ds.Tables[0];
            Con.Close();

        }

        public void TextboxFilter()
        {
            Con.Open();
            string query = "select * from StuDetails where Regno='" + txtroom.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            table_liveStatus.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStudent Managestu = new ManageStudent();
            Managestu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void living_Load(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            populateGrid();
            txtroom.Text = "";
        }
    }
}
