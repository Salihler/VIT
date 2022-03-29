using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using MimeKit;
using MimeKit.Text;
using MimeKit.Utils;

namespace VIT
{
    public class MailServices
    {
        private const string SmtpServer = "";

        private const string SmtpUser = "";

        private const string SmtpPass = "";

        private const string SmtpFrom = "";

        public string ReadBody()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = System.IO.Path.Combine(currentDirectory, "MailBodies", "AcciMailBody.html");
            var body = File.ReadAllText(filePath);
            return body;
        }

        public void SendCvBank()
        {
            try
            {
                using (var mailClient = new MailMessage())
                {
                    var smtpServer = new SmtpClient(SmtpServer)
                    {
                        //Host = "",
                        //Credentials = new NetworkCredential(SmtpUser, SmtpPass),
                        Port = 25
                    };

                    mailClient.From = new MailAddress(SmtpFrom);

                    mailClient.To.Add("eren.salihler@acibadem.com");

                    mailClient.Subject = "konu";

                    mailClient.Body = "GenerateMailingForCvBank(nameSurname, citizenOf, email, phone, facultyOfStudy, universityOfStudy, expertise, expertiseOrganization, title, cityOfWish, locationOfWish, isWorkingAnywhere, workingCompany, cvFile, appliedPosition)";

                    mailClient.BodyEncoding = Encoding.UTF8;

                    mailClient.IsBodyHtml = true;

                    smtpServer.Send(mailClient);
                }
            }
            finally
            {
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            }
        }
        
    }
}