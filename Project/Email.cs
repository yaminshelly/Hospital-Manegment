using System;
using System.Windows.Forms;
using System.Net.Mail;


namespace Project
{
    public partial class Email : UserControl
    {

      
        public Email()
        {
            InitializeComponent();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MailMessage mm = new MailMessage("psychiatricward.kinneret@gmail.com", txtRecipent.Text.Trim()))
            {
                mm.Subject = txtSubject.Text;//נושא
                mm.Body = rtxtBody.Text; // תוכן המכתב

                mm.IsBodyHtml = false;// התוכן הוא לא קוד html
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //כתובת השרת ממנו שולחים מייל
                smtp.Port = 587;//פורט השרת ממנו שולחים
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("psychiatricward.kinneret@gmail.com", "teamshelly2020");//מייל שממנו שולחים וסיסמא 

                smtp.Send(mm);
                MessageBox.Show("Email sent.", "Message");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        

        }

       


    }
}


