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
    public partial class deleteroom : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
        public deleteroom()
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
            string query = "select * from Assets where Room_no=" + txtroom.Text + "";
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

        private void deleteroom_Load(object sender, EventArgs e)
        {
           
            
            populateGrid();

        }

        private void cmbfloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxFilter();
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

        private void table_asserts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table_asserts.Columns[e.ColumnIndex].HeaderText == "Delete Details")
            {
                string RoomId;
                RoomId = Convert.ToString(table_asserts.Rows[e.RowIndex].Cells["Column10"].Value);
                Con.Open();
                try
                {
                    string query = "DELETE FROM Assets WHERE  RoomId=@RoomId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@RoomId", RoomId);
                    int result = cmd.ExecuteNonQuery();

                    if(result>0)
                    {
                        MessageBox.Show("Room Deleted Successfull");
                    }
                    else
                    {
                        MessageBox.Show("Data Not Deleted");

                    }


                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Con.Close();
                }
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
    }
}
