using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hostelloginpage
{
    public partial class Roomdetails : Form
    {
        function fn = new function();
        string query;

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");

        public Roomdetails()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select RoomId from Assets where RoomId='" + txtroomid + "' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("The Room Id allready Existing .");
            }
            else if (txtroomid.Text !=""&&cmbfloor.SelectedItem !="" && txtroom.Text != "" && txtfrontkey.Text != "" && txtbackkey.Text !="" && txtbed.Text !="" && txtmat.Text !="" && txttable.Text !="" && txtchairs.Text !="" && txtfan.Text !="")
            {
                query = "insert into Assets(RoomId,Floor,Room_no,Frontkey,Backkey,Beds,Mattress,Tables,Chairs,Fans) values ('" + txtroomid.Text + "','" + cmbfloor.SelectedItem + "'," + txtroom.Text + "," + txtfrontkey.Text + ", " + txtbackkey.Text + "," + txtbed.Text + "," + txtmat.Text + "," + txttable.Text + "," + txtchairs.Text + "," + txtfan.Text + ")";
                fn.setData(query,"Room Assets details Added.");

                txtroomid.Text = "";
                cmbfloor.Text= string.Empty;
                txtbackkey.Text = "";
                txtbed.Text = "";
                txtchairs.Text = "";
                txtfan.Text = "";
                txtfrontkey.Text = "";
                txtmat.Text = "";
                txtroom.Text = "";
                txttable.Text = "";

            }
           else
            {
                MessageBox.Show("Fill All fields", "Warning !! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAsserts mngass = new ManageAsserts();
            mngass.Show();
        }

        private void Roomdetails_Load(object sender, EventArgs e)
        {

        }

        private void txtroom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtfrontkey.Focus();
            }
        }

        private void txtfrontkey_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtbackkey.Focus();
            }
        }

        private void txtbackkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbed.Focus();
            }
        }

        private void txtbed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmat.Focus();
            }
        }

        private void txtmat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txttable.Focus();
            }
        }

        private void txttable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtchairs.Focus();
            }
        }

        private void txtchairs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtfan.Focus();
            }
        }

        private void txtfan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
           
        }

        private void txtfrontkey_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(txtfrontkey.Text, out box_int);
            if(box_int > 5 && txtfrontkey.Text !="")
            {
                MessageBox.Show("Maximum Allowed Number is 5");
            }
        }

        private void txtbackkey_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(txtbackkey.Text, out box_int);
            if (box_int > 5 && txtbackkey.Text != "")
            {
                MessageBox.Show("Maximum Allowed Number is 5");
            }
        }

        private void txtbed_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(txtbed.Text, out box_int);
            if (box_int > 5 && txtbed.Text != "")
            {
                MessageBox.Show("Maximum Allowed Number is 5");
            }
        }

        private void txtmat_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(txtmat.Text, out box_int);
            if (box_int > 5 && txtmat.Text != "")
            {
                MessageBox.Show("Maximum Allowed Number is 5");
            }
        }

        private void txttable_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(txttable.Text, out box_int);
            if (box_int > 5 && txttable.Text != "")
            {
                MessageBox.Show("Maximum Allowed Number is 5");
            }
        }

        private void txtchairs_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(txtchairs.Text, out box_int);
            if (box_int > 5 && txtchairs.Text != "")
            {
                MessageBox.Show("Maximum Allowed Number is 5");
            }
        }

        private void txtfan_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(txtfan.Text, out box_int);
            if (box_int > 5 && txtfan.Text != "")
            {
                MessageBox.Show("Maximum Allowed Number is 5");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbfloor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtroomid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtroomid_MouseHover(object sender, EventArgs e)
        {
            txtroomid.Text="This is unique key .";
        }

        private void txtroomid_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void txtroomid_MouseLeave(object sender, EventArgs e)
        {
            txtroomid.Text = "";
        }
    }
}
