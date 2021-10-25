using System;
using System.Windows.Forms;
using System.Net.Mail;


namespace Project
{
    static class SendEmail
    {
        
        static SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
      

        

        public static void sendWelcomeMessage(string to_email, string name, string room, string bed, string diagnosis)//הודעה למטופל חדש
        {
            using (MailMessage mm = new MailMessage("psychiatricward.kinneret@gmail.com", to_email))
            {
                mm.Subject = "Welcome To Our Psychiatric Ward!";//נושא
                mm.Body = "Hi " + name+ "\n" + "Welcome to our psychiatric ward. You are diagnosed with " + diagnosis + ".\n" + "Your room number is " + room + " and your bed number is "+bed ; // תוכן המכתב

                mm.IsBodyHtml = false;// התוכן הוא לא קוד html
                
                
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("psychiatricward.kinneret@gmail.com", "teamshelly2020");//מייל שממנו שולחים וסיסמא 

                smtp.Send(mm);
                
            }

        }


        public static void goodbyMessage(string to_email, string name, int days)//הודעה למטופל משתחרר
        {

            using (MailMessage mm = new MailMessage("psychiatricward.kinneret@gmail.com", to_email))
            {

               


                int moneyOwed = (days+1) * 20;
                mm.Subject = "Goodbye " + name;//נושא
                mm.Body = "Dear patient, \nWe wish you all the luck in the future!\nYou Owe us: " + moneyOwed.ToString() + "$"; // תוכן המכתב

                mm.IsBodyHtml = false;// התוכן הוא לא קוד html


                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("psychiatricward.kinneret@gmail.com", "teamshelly2020");//מייל שממנו שולחים וסיסמא 

                smtp.Send(mm);

            }

        }






    }
}
