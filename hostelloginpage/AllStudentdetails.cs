using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hostelloginpage
{
    public partial class AllStudentdetails : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
        public AllStudentdetails()
        {
            InitializeComponent();
        }

        public void populateGrid()
        {
            Con.Open();
            string query = "select Regno,Fullname,Surname,Address,Faculty,Course,YearofStudy,Room from StuDetails";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            table_studentsdetails.DataSource = ds.Tables[0];
            Con.Close();

        }


        public void TextboxFilter()
        {
            Con.Open();
            string query = "select Regno,Fullname,Surname,Address,Faculty,Course,YearofStudy,Room from StuDetails where Regno='" + txtroom.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            table_studentsdetails.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void AllStudentdetails_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStudent mngstu = new ManageStudent();
            mngstu.Show();
        }

        //try to redirect floors
        private void guna2ButtonBackToFloors_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage_rooms manageRoom = new Manage_rooms();
            manageRoom.Show();
        }

        private void table_studentsdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table_studentsdetails.Columns[e.ColumnIndex].HeaderText == "View Full Details")
            {

                string Student;
                Student = Convert.ToString(table_studentsdetails.Rows[e.RowIndex].Cells["Column2"].Value);
                stuFullDetails det = new stuFullDetails(Student);
                det.ShowDialog();

            }

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
