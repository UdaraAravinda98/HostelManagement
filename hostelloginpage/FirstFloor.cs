using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hostelloginpage
{
    public partial class FirstFloor : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
      

        public FirstFloor()
        {
            InitializeComponent();
        }

        public void populateGrid()
        {
            
            Con.Open();

            string query = "select Assets.RoomId,StuDetails.Regno, Assets.Frontkey, Assets.Backkey, Assets.Beds, Assets.Mattress, Assets.Tables, Assets.Chairs, Assets.Fans ,Assets.Floor from Assets inner join StuDetails on  Assets.RoomId = StuDetails.Room and Assets.Floor = 'First Floor' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            table_firstfloor.DataSource = dt;
            Con.Close();
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

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_rooms mnsroom = new Manage_rooms();
            mnsroom.Show();
        }

        private void guna2GradientTileButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Manage_rooms mnsroom = new Manage_rooms();
            mnsroom.Show();
        }

        
        //try to add button to students details --new one
        

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        public void TextboxFilter()
        {
            Con.Open();
            string query = "select Assets.RoomId,StuDetails.Regno, Assets.Frontkey, Assets.Backkey, Assets.Beds, Assets.Mattress, Assets.Tables, Assets.Chairs, Assets.Fans ,Assets.Floor from Assets inner join StuDetails on  Assets.RoomId = StuDetails.Room and Assets.RoomId = '"+ txtid.Text +"'  ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            table_firstfloor.DataSource = ds.Tables[0];
            Con.Close();

        }



        private void FirstFloor_Load_1(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }

        private void table_firstfloor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (table_firstfloor.Columns[e.ColumnIndex].HeaderText == "Regno")
            {

                string Student;
                Student = Convert.ToString(table_firstfloor.Rows[e.RowIndex].Cells["Regno"].Value);
                showstudentdet det = new showstudentdet(Student);
                det.ShowDialog();

            }


            //this.Hide();

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            populateGrid();
            txtid.Text = "";
        }
    }
}
