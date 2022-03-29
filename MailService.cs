using System;
using System.IO;
using System.Net.Mail;
using System.Text;
using MimeKit;
using MimeKit.Utils;

namespace VIT
{
    public class MailService
    {
        private readonly string _smtpServer = "";

        private readonly string _smtpUser = "eren.salihler";
        //private readonly string _smtpUser = "webapp";

        private readonly string _smtpPass = "";
        //private readonly string _smtpPass = "";

        //private readonly string _smtpFrom = "eren.salihler@acibadem.com";
        //private readonly string _smtpFrom = "";
        private readonly MailAddress _smtpFrom = new MailAddress("", "Eren Salihler");

        //private readonly MailAddress _smtpTo = new MailAddress("", "Çağrı Merkezi Ekip Liderleri");
        private readonly MailAddress _smtpTo = new MailAddress("", "Eren Salihler");

        

        private readonly int _smtpPort = 25;

        public void SendAcci()
        {
            // var email = new MailMessage();
            // var builder = new BodyBuilder();

            // var image = builder.LinkedResources.Add(@"img\acciLogo.png");
            // image.ContentId = MimeUtils.GenerateMessageId();

            var body = ReadBody();
            string subject = "ACCI Yeni Versiyon Bilgilendirmesi";
            string imagePath = "img\acciLogo.png";

            // builder.HtmlBody = body.Replace("{0}", image.ContentId);

            //sendHtmlEmail(_smtpFrom,_smtpTo,body,subject,_smtpServer,_smtpPort,imagePath);
            Console.WriteLine("Gönderildi...");
        }

        public string ReadBody()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = System.IO.Path.Combine(currentDirectory, "MailBodies", "AcciMailBody.html");
            var body = File.ReadAllText(filePath);
            return body;
        }

        // protected void sendHtmlEmail(MailAddress from_Email, MailAddress to_Email, string body, string Subject, string SMTP_IP, Int32 SMTP_Server_Port, string imagePath)
        // {
        //     //create an instance of new mail message
        //     MailMessage mail = new MailMessage();

        //     //set the HTML format to true
        //     mail.IsBodyHtml = true;

        //     //create Alrternative HTML view
        //     AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body, null, "text/html");

        //     //Add Image
        //     LinkedResource theEmailImage = new LinkedResource(imagePath);
        //     theEmailImage.ContentId = "myImageID";

        //     //Add the Image to the Alternate view
        //     htmlView.LinkedResources.Add(theEmailImage);

        //     //Add view to the Email Message
        //     mail.AlternateViews.Add(htmlView);

        //     //set the "from email" address and specify a friendly 'from' name
        //     mail.From = from_Email;

        //     //set the "to" email address
        //     mail.To.Add(to_Email);

        //     //set the Email subject
        //     mail.Subject = Subject;

        //     //set the SMTP info

        //     SmtpClient smtp = new SmtpClient(SMTP_IP,SMTP_Server_Port);
        //     //send the email
        //     smtp.Send(mail);
        // }
    }
}
