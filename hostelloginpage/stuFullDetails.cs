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
    public partial class stuFullDetails : Form
    {

        string Student1;

       
        public stuFullDetails(string Student)
        {
            InitializeComponent();
            Student1 = Student;
        }

        private void stuFullDetails_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= " + AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "HostelDB.mdf; Integrated Security = True");
            Con.Open();
            string query = "Select * from StuDetails where Regno=@Regno";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@Regno", Student1);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                txtStuRegNo.Text = da.GetValue(0).ToString();
                txtStuFullName.Text = da.GetValue(1).ToString();
                txtStuSurName.Text = da.GetValue(2).ToString();
                txtStuAddress.Text = da.GetValue(3).ToString();
                txtStuDistrict.Text = da.GetValue(4).ToString();
                txtStuGsDiv.Text = da.GetValue(5).ToString();
                txtStuDsDiv.Text = da.GetValue(6).ToString();
                txtStuNic.Text = da.GetValue(9).ToString();
                txtStuSex.Text = da.GetValue(7).ToString();
                txtStuBD.Text = da.GetValue(8).ToString();
                txtStuFaculty.Text = da.GetValue(10).ToString();
                txtStuCourse.Text = da.GetValue(11).ToString();
                txtStuYear.Text = da.GetValue(12).ToString();
                txtStuContactNo.Text = da.GetValue(13).ToString();
                txtStuEmail.Text = da.GetValue(14).ToString();
                txtStuMedical.Text = da.GetValue(15).ToString();
                txtStuFloor.Text = da.GetValue(21).ToString();
                txtStuRoom.Text = da.GetValue(22).ToString();
                txtGurName.Text = da.GetValue(16).ToString();
                txtRelationship.Text = da.GetValue(17).ToString();
                txtGurAddress.Text = da.GetValue(18).ToString();
                txtGurContactNo.Text = da.GetValue(19).ToString();
                txtPolice.Text = da.GetValue(20).ToString();



            }
            Con.Close();
            txtStuRegNo.Text = Student1;
        }

        private void stuDsDiv_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            AllStudentdetails alldet = new AllStudentdetails();
            alldet.Show();
        }
    }
}
