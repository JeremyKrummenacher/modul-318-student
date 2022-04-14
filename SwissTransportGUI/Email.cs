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
        string emailList;
        public Email(string list)
        {
            InitializeComponent();
            this.emailList = list;
            //test
        }

        private void absendenBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string addMail = AntextBox.Text;
                string subject = BetrefftextBox.Text;
                string body = richTextBox1.Text;

                List<string> emailRows = emailList.Split('/').ToList();
                foreach (string emailRow in emailRows)
                {
                    body += emailRow.Replace('|', ' ') + "\n";
                }

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


                AntextBox.Text = "";
                BetrefftextBox.Text = "";
                richTextBox1.Text = "";

                this.Close();
            }
            catch
            {
                if (AntextBox.Text == "")
                {
                    MessageBox.Show("Geben Sie eine E-Mailadresse ein: ");
                }
                else if (BetrefftextBox.Text == "")
                {
                    MessageBox.Show("Geben Sie ein Betreff ein: ");
                }
            }

        }
    }
}
