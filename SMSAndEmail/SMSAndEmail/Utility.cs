using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SMSAndEmail
{
    class Utility
    {
        public static void sendMail()
        {

            //We need to enable access to less secure apps using the following link for host gmail id:
            //https://myaccount.google.com/lesssecureapps
            //and enable this as well: https://accounts.google.com/DisplayUnlockCaptcha
            try
            {
                SmtpClient client = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential("GMAIL ID I.E. XX@GMAIL.COM", "GMAIL PASSWORD I.E XXX"),
                    Timeout = 10000,
                };
                MailMessage mm = new MailMessage("GMAIL ID I.E. XX@GMAIL.COM", "EXAMPLE@GMAIL.COM", "subject", "body");
                client.Send(mm);
                Console.WriteLine("Email Sent");
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not end email\n\n" + e.ToString());
            }
        }

        public static int GenerateRandomNumber()
        {
            //This will generate a 5 digit random number
            Random rnd = new Random();
            return rnd.Next(10000, 99999);
        }
    }
}
