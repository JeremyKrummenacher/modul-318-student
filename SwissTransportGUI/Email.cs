using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                string addMail = textBox1.Text;
                string subject = textBox2.Text;
                string body = richTextBox1.Text;

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("krummenacherjeremy@gmail.com");
                mail.To.Add(addMail);
                mail.Subject = subject;
                mail.Body = body;// + GetInformations();

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("krummenacherjeremy@gmail.com", "jeremy_13245");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");


                textBox1.Text = "";
                textBox2.Text = "";
                richTextBox1.Text = "";

                this.Close();
            }
            catch
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Geben Sie eine E-Mailadresse ein: ");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Geben Sie ein Betreff ein: ");
                }
            }

        }
    }
}
