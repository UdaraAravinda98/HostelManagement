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
using System.Data;
using System.Data.SqlClient;

namespace hostelloginpage
{
    public partial class EditStudentDetails : Form
    {

        string query;
        function obj1 = new function();


        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        int pos = 0;
        public EditStudentDetails()
        {
            InitializeComponent();
        }

        public void TextboxFilter()
        {
            SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
            Con.Open();
            string query = "select * from StuDetails where Regno='" + txtregno.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("Regno", txtregno.Text);
            SqlDataReader reader;

            reader=cmd.ExecuteReader();
            
         
            if(reader.Read())
            {
                textBox1.Text = reader["Fullname"].ToString();
                textBox2.Text = reader["Surname"].ToString();
                textBox3.Text = reader["Address"].ToString();
                textBox4.Text = reader["District"].ToString();
                textBox5.Text = reader["GSDivision"].ToString();
                textBox6.Text = reader["DSDivision"].ToString();
                textBox7.Text = reader["Sex"].ToString();
                textBox9.Text = reader["DateOfBirth"].ToString();
                textBox8.Text = reader["NICno"].ToString();
                textBox10.Text = reader["Regno"].ToString();
                textBox11.Text = reader["Faculty"].ToString();
                textBox12.Text = reader["Course"].ToString();
                textBox13.Text = reader["YearofStudy"].ToString();
                textBox14.Text = reader["ContactNo"].ToString();
                textBox15.Text = reader["EmailID"].ToString();
                textBox17.Text = reader["GuardianName"].ToString();
                textBox16.Text = reader["Guardiancontactno"].ToString();
                textBox18.Text = reader["GuardianRelationship"].ToString();
                textBox19.Text = reader["GuardianAddress"].ToString();
                textBox20.Text = reader["Floorno"].ToString();
                textBox21.Text = reader["Room"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found.");
            }
            Con.Close();
            

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
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

        private void guna2GradientTileButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ManageStudent Managestu = new ManageStudent();
            Managestu.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ManageStudent manageStu = new ManageStudent();
            manageStu.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" &&
              textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "" &&
              textBox18.Text != "" && textBox19.Text != "" && textBox20.Text != "" && textBox21.Text != "")
            {



                string fullnm = textBox1.Text;
                string surnm = textBox2.Text;
                string adrs = textBox3.Text;
                string dstrct = textBox4.Text;
                string gsdiv = textBox5.Text;
                string dsdiv = textBox6.Text;
                string sx = textBox7.Text;
                string dob = textBox9.Text;
                string nic = textBox8.Text;
                string rgno = textBox10.Text;
                string fclty = textBox11.Text;
                string cs = textBox12.Text;
                string yos = textBox13.Text;
                string cn = textBox14.Text;
                string emid = textBox15.Text;
                string guardnm = textBox17.Text;
                string guardcn = textBox16.Text;
                string guardrel = textBox18.Text;
                string guardadrs = textBox19.Text;
                string fl = textBox20.Text;
                string rm = textBox21.Text;

                Con.Open();

                try
                {
                    string query = "UPDATE StuDetails SET  Fullname=@Fullname, Surname=@Surname, Address=@Address, District=@District, GSDivision=@GSDivision, DSDivision=@DSDivision, Sex=@Sex, NICno=@NICno,DateOfBirth = @DateOfBirth, Faculty = @Faculty, Course = @Course, YearofStudy = @YearofStudy, ContactNo =@ContactNo, EmailID = @EmailID, GuardianName = @GuardianName,GuardianRelationship = @GuardianRelationship, GuardianAddress = @GuardianAddress, Guardiancontactno = @Guardiancontactno, Floorno = @Floorno, Room = @Room where Regno=@Regno";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@Fullname", fullnm);
                    cmd.Parameters.AddWithValue("@Surname", surnm);
                    cmd.Parameters.AddWithValue("@Address", adrs);
                    cmd.Parameters.AddWithValue("@District", dstrct);
                    cmd.Parameters.AddWithValue("@GSDivision", gsdiv);
                    cmd.Parameters.AddWithValue("@DSDivision", dsdiv);
                    cmd.Parameters.AddWithValue("@Sex", sx);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                    cmd.Parameters.AddWithValue("@NICno", nic);
                    cmd.Parameters.AddWithValue("@Regno", rgno);
                    cmd.Parameters.AddWithValue("@Faculty", fclty);
                    cmd.Parameters.AddWithValue("@Course", cs);
                    cmd.Parameters.AddWithValue("@YearofStudy", yos);
                    cmd.Parameters.AddWithValue("@ContactNo", cn);
                    cmd.Parameters.AddWithValue("@EmailID", emid);
                    cmd.Parameters.AddWithValue("@GuardianName", guardnm);
                    cmd.Parameters.AddWithValue("@Guardiancontactno", guardcn);
                    cmd.Parameters.AddWithValue("@GuardianRelationship", guardrel);
                    cmd.Parameters.AddWithValue("@GuardianAddress", guardadrs);
                    cmd.Parameters.AddWithValue("@Floorno", fl);
                    cmd.Parameters.AddWithValue("@Room", rm);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Updated Successfull.");
                       
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

            else
            {
                MessageBox.Show("Fill All fields", "Warning !! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox17.Text = "";
            textBox16.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            txtregno.Text = "";
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }

        private void EditStudentDetails_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
            Con.Open();
            string query = "delete from StuDetails where Regno='" + txtregno.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("Regno", txtregno.Text);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            MessageBox.Show("Student details deleted");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox17.Text = "";
            textBox16.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            txtregno.Text = "";
        }
    }
}
