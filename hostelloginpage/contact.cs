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
    public partial class contact : Form
    {
        public static string to;
        public contact()
        {
            InitializeComponent();
        }

        private void btnback_contactus_Click(object sender, EventArgs e)
        {
            this.Hide();
            frontpage frnpage = new frontpage();
            frnpage.Show();
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

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (msg.Text != "")
            {
                string from, pass, messageBody;
                MailMessage message = new MailMessage();
                to = email.Text.ToString();
                from = "hostelmanagementuov@gmail.com";
                pass = "stsqvgbchnhynpph";
                messageBody = (msg.Text).ToString(); ;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Hostel Management System Report Problem .";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    msg.Text = "";
                    name.Text = "";
                    email.Text = "";
                    MessageBox.Show("Mail Sent Successfully");
                    this.Hide();
                    frontpage frn = new frontpage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fill the text boxes .");
            }

        }
    }
}
