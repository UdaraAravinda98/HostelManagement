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


    public partial class EditAss : Form
    {
        int  Room_no1,Frontkey1, Backkey1, Beds1, Mattress1, Tables1, Chairs1, Fans1;
        string id1,floor1;
        private void lableroomno_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public EditAss(string id,string floor,int Room_no, int Frontkey, int Backkey, int Beds, int Mattress, int Tables, int Chairs, int Fans)
        {
            InitializeComponent();
            id1 = id;
            floor1 = floor;
            Room_no1 = Room_no;
            Frontkey1 = Frontkey;
            Backkey1 = Backkey;
            Beds1 = Beds;
            Mattress1 = Mattress;
            Tables1 = Tables;
            Chairs1 = Chairs;
            Fans1 = Fans;

        }

        private void EditAss_Load(object sender, EventArgs e)
        {
            lableroomno.Text = Room_no1.ToString();
            lablefloor.Text = floor1;
            txtfrontkey.Text = Frontkey1.ToString();
            txtbackkey.Text = Backkey1.ToString();
            txtbed.Text = Beds1.ToString();
            txtmat.Text = Mattress1.ToString();
            txttable.Text = Tables1.ToString();
            txtchairs.Text = Chairs1.ToString();
            txtfan.Text = Fans1.ToString();
            
        }

       

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Room_no1 = Convert.ToInt32(lableroomno.Text);
            floor1 = lablefloor.Text;
            Frontkey1 = Convert.ToInt32(txtfrontkey.Text);
            Backkey1 = Convert.ToInt32(txtbackkey.Text);
            Beds1 = Convert.ToInt32(txtbed.Text);
            Mattress1 = Convert.ToInt32(txtmat.Text);
            Tables1 = Convert.ToInt32(txttable.Text);
            Chairs1 = Convert.ToInt32(txtchairs.Text);
            Fans1 = Convert.ToInt32(txtfan.Text);

            SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
            Con.Open();
            try
            {
                string query = "UPDATE Assets SET FrontKey=@Frontkey,Backkey=@Backkey,Beds=@beds,Mattress=@Mattress,Tables=@Tables,Chairs=@Chairs,Fans=@Fans WHERE RoomId=@RoomId";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@RoomId", id1);
                cmd.Parameters.AddWithValue("@FrontKey", Frontkey1);
                cmd.Parameters.AddWithValue("@BackKey", Backkey1);
                cmd.Parameters.AddWithValue("@Beds", Beds1);
                cmd.Parameters.AddWithValue("@Mattress", Mattress1);
                cmd.Parameters.AddWithValue("@Tables", Tables1);
                cmd.Parameters.AddWithValue("@Chairs", Chairs1);
                cmd.Parameters.AddWithValue("@Fans", Fans1);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data Updated Successfull.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data Not Updated");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }

        }


    }
}
