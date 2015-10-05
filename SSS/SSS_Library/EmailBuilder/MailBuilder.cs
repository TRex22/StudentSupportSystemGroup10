using System.Net;
using System.Net.Mail;

//see readme

namespace SSS_Library.EmailBuilder
{
    public class MailSender : IMailSender
    {
        // Mail-sending code will happen here . . .
        public static void SendSmtpMail(SmtpClient client, MailMessage message, bool? defaultSettings)
        {
            if (defaultSettings == true)
            {
                client = new SmtpClient();
                client.Host = "smtp.googlemail.com";
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("myemail@gmail.com", "password");
            }
            
            client.Send(message);
        }

        public static MailMessage MakeEmailMessage(string from, string to, string subject, string body)
        {
            var mail = new MailMessage(from, to, subject, body);
            return mail;
        }

        public static void SendAnEmail(string from, string to, string subject, string body)
        {
            var email = MakeEmailMessage(from, to, subject, body);
            SendSmtpMail(new SmtpClient(), email, null);
        }
    }
}
