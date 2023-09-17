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
    public partial class EditAsserts : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");

        public EditAsserts()
        {
            InitializeComponent();
        }

        public void populateGrid()
        {
            Con.Open();
            string query = "select * from Assets";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            table_asserts.DataSource = ds.Tables[0];
            Con.Close();

        }

        public void TextboxFilter()
        {
            Con.Open();
            string query = "select * from Assets where Room_no=" + txtroom .Text + "";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            table_asserts.DataSource = ds.Tables[0];
            Con.Close();

        }

        public void comboboxFilter()
        {
            Con.Open();
            string query = "select * from Assets where Floor='" + cmbfloor.SelectedItem.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            table_asserts.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void cmbfloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxFilter();
        }

        private void EditAsserts_Load(object sender, EventArgs e)
        {
            
            populateGrid();
            
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            TextboxFilter();
            cmbfloor.Text = string.Empty;
            txtroom.Text = "";

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            populateGrid();
            txtroom.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtroom_TextChanged(object sender, EventArgs e)
        {

        }

        private void table_asserts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(table_asserts.Columns[e.ColumnIndex].HeaderText == "Edit Details")
            {
                int Room_no, Frontkey, Backkey, Beds, Mattress, Tables, Chairs, Fans;
                string RoomId,floor;
                RoomId = Convert.ToString(table_asserts.Rows[e.RowIndex].Cells["Column1"].Value);
                floor = Convert.ToString(table_asserts.Rows[e.RowIndex].Cells["Column2"].Value);
                Room_no = Convert.ToInt32(table_asserts.Rows[e.RowIndex].Cells["Column3"].Value);
                Frontkey = Convert.ToInt32(table_asserts.Rows[e.RowIndex].Cells["Column4"].Value);
                Backkey = Convert.ToInt32(table_asserts.Rows[e.RowIndex].Cells["Column5"].Value);
                Beds = Convert.ToInt32(table_asserts.Rows[e.RowIndex].Cells["Column6"].Value);
                Mattress = Convert.ToInt32(table_asserts.Rows[e.RowIndex].Cells["Column9"].Value);
                Tables = Convert.ToInt32(table_asserts.Rows[e.RowIndex].Cells["Column7"].Value);
                Chairs = Convert.ToInt32(table_asserts.Rows[e.RowIndex].Cells["Column8"].Value);
                Fans = Convert.ToInt32(table_asserts.Rows[e.RowIndex].Cells["Column10"].Value);

                EditAss edit = new EditAss(RoomId, floor,Room_no,Frontkey, Backkey, Beds, Mattress, Tables, Chairs, Fans);
                edit.ShowDialog();



            }
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
            ManageAsserts mngass = new ManageAsserts();
            mngass.Show();
        }

        private void table_asserts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
