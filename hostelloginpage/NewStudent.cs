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
    public partial class NewStudent : Form
    {

        string query;
        function obj1 = new function();


        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        int pos = 0;
        
        public NewStudent()
        {
            InitializeComponent();
        }

        

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
        
        private void btn_newstudent_Click_1(object sender, EventArgs e)
        {

        }

        private void NewStudent_Load_1(object sender, EventArgs e)
        {
            
            SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
            string query = "select * from Student";
            adapter = new SqlDataAdapter(query, Con);
            adapter.Fill(dt);


            adapter = new SqlDataAdapter("SELECT DISTINCT Floor from Assets", Con);
            DataTable DT = new DataTable();
            adapter.Fill(DT);
            boxfloor.Items.Clear();
            boxfloor.Items.Add("---SELECT---");

            foreach(DataRow Row in DT.Rows)
            {
                boxfloor.Items.Add(Row["Floor"].ToString());
            }
            

            



        }

        private void btn_newstudent_Click_2(object sender, EventArgs e)
        {
            this.Show();
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

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frontpage frnpage = new frontpage();
            frnpage.Show();
        }

        private void btnim_Click(object sender, EventArgs e)
        {
            ExcelToSql insert = new ExcelToSql();
            insert.ShowDialog();
        }

        public void showdata(int Index)
        {
            
            textBox1.Text = dt.Rows[Index]["Fullname"].ToString();
            textBox2.Text = dt.Rows[Index]["Surname"].ToString();
            textBox3.Text = dt.Rows[Index]["Address"].ToString();
            textBox4.Text = dt.Rows[Index]["District"].ToString();
            textBox5.Text = dt.Rows[Index]["GSdivision"].ToString();
            textBox6.Text = dt.Rows[Index]["DSdivision"].ToString();
            textBox7.Text = dt.Rows[Index]["Sex"].ToString();
            textBox8.Text = dt.Rows[Index]["DOB"].ToString();
            textBox9.Text = dt.Rows[Index]["NICno"].ToString(); 
            textBox10.Text = dt.Rows[Index]["Regno"].ToString();
            textBox11.Text = dt.Rows[Index]["Faculty"].ToString();
            textBox12.Text = dt.Rows[Index]["Course"].ToString();
            textBox13.Text = dt.Rows[Index]["Yearofstudy"].ToString();
            textBox14.Text = dt.Rows[Index]["Contact"].ToString();
            textBox15.Text = dt.Rows[Index]["Email"].ToString();
            comboBox2.SelectedItem = dt.Rows[Index]["Medicalhistory"].ToString();
            textBox17.Text = dt.Rows[Index]["Guardianname"].ToString();
            textBox18.Text = dt.Rows[Index]["Guardianrelationship"].ToString();
            textBox19.Text = dt.Rows[Index]["GuardianAddress"].ToString();
            textBox20.Text = dt.Rows[Index]["Guardiancontact"].ToString();
            textBox21.Text = dt.Rows[Index]["Nearbypolice"].ToString();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            pos = 0;
            showdata(pos);


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            pos++;
            if(pos < dt.Rows.Count)
            {
                showdata(pos);
            }
            else
            {
                MessageBox.Show("END");
                pos = dt.Rows.Count - 1;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos >= 0)
            {
                showdata(pos);
            }
            else
            {
                MessageBox.Show("END");
               
            }
        }

        public void comboboxFilter()
        {
            Con.Open();
            string query = "select * from Assets where Floor='" + boxfloor.SelectedItem.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Con.Close();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" &&
                textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "" && comboBox2.SelectedItem != "" && textBox17.Text != "" &&
                textBox18.Text != "" && textBox19.Text != "" && textBox20.Text != "" && textBox21.Text != "" && boxfloor.SelectedItem != "" && comboBox1.SelectedItem != "")
            {
                


                query = " insert into StuDetails(Regno,Fullname,Surname,Address,District,GSDivision,DSDivision,Sex,NICno,DateOfBirth,Faculty,Course,YearofStudy,ContactNo,EmailID,MedicalHistrory,GuardianName,GuardianRelationship,GuardianAddress,Guardiancontactno,Policenear,Floorno,Room) values ( '" + textBox10.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox11.Text + "' ,'" + textBox12.Text + "', '" + textBox13.Text + "', '" + textBox14.Text + "', '" + textBox15.Text + "','" + comboBox2.SelectedItem + "', '" + textBox17.Text + "','" + textBox18.Text + "', '" + textBox19.Text + "','" + textBox20.Text + "', '" + textBox21.Text + "', '" + boxfloor.SelectedItem + "', '" + comboBox1.SelectedItem + "')";
                obj1.setData(query,"Student Details Added .");
               

            }

            else
            {
                MessageBox.Show("Fill All fields", "Warning !! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxFilter();

            

        }

        private void boxfloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT RoomId from Assets where Floor ='" + boxfloor.Text + "' ", Con);
            DataTable DT = new DataTable();
            adapter.Fill(DT);
            comboBox1.Items.Clear();
            foreach (DataRow Row in DT.Rows)
            {
                comboBox1.Items.Add(Row["RoomId"].ToString());
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            comboBox2.SelectedItem = string.Empty;
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            boxfloor.SelectedItem = string.Empty;
            comboBox1.SelectedItem = string.Empty;

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            string query = "select Floor,Room_no,RoomId from Assets where Floor ='" + comboBox1.Text +"' AND Room_no ='" + boxfloor.Text +"' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string id = (string)dr["RoomId"].ToString();
                textBox16.Text = id;
            }
            Con.Close();
            

        }

        private void guna2GradientTileButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            contact con = new contact();
            con.Show();
        }

        private void guna2GradientTileButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            aboutus about = new aboutus();
            about.Show();
        }
    }
}
