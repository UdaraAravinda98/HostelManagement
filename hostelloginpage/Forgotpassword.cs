using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace hostelloginpage
{
    public partial class Forgotpassword : Form
    {
        string randomCode;
        public static string to;

        public Forgotpassword()
        {
            InitializeComponent();
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtemail.Text).ToString();
            from = "hostelmanagementuov@gmail.com";
            pass = "stsqvgbchnhynpph";
            messageBody = "Your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password reseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Sent Successfully");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            if(randomCode == (txtcode.Text).ToString())
            {
                to = txtemail.Text;
                Reset re = new Reset();
                this.Hide();
                re.Show();
            }
            else
            {
                MessageBox.Show("wrong code");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsent.PerformClick();
            }
        }

        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnverify.PerformClick();
            }
        }

        private void Forgotpassword_Load(object sender, EventArgs e)
        {

        }
    }
}
