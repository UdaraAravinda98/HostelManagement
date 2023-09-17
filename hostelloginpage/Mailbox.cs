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
    public partial class Mailbox : Form
    {
        string randomCode;
        public static string to;

        public Mailbox()
        {
            InitializeComponent();
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            if (Txtto.Text != "" )
            {
                string from, pass, messageBody;
                Random rand = new Random();
                MailMessage message = new MailMessage();
                to = (Txtto.Text).ToString();
                from = "hostelmanagementuov@gmail.com";
                pass = "stsqvgbchnhynpph";
                messageBody = "https://docs.google.com/forms/d/e/1FAIpQLSfPpbWp31oPHB4kDkAAFywXD39tWQdzrClLjOeCT-H6Xgz1DA/viewform?usp=sf_link";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Hostel Registration Google form .";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    Txtto.Text = "";
                    MessageBox.Show("Mail Sent Successfully");
                    this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Txtto.Text = "";
            this.Close();
            frontpage frn = new frontpage();
        }
    }
}
