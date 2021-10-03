using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text;
using NUnit.Framework;

namespace FaceBook_DataDriven_Testing.GMail
{
    public class Gmail : BaseClass.BaseClass1
    {
        public static GMExcelOperation excel;
        //Here we are reading the data from excel
        public static void ReadDataFromExcel()
        {
            excel = new GMExcelOperation();
            excel.PopulateFromExcel(@"C:\Users\HP\source\repos\FaceBook_DataDriven_Testing\FaceBook_DataDriven_Testing\MailData.xlsx");
        }



        public static void email_send()
        {
            excel = new GMExcelOperation();
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            //we are sending our from mail id
            mail.From = new MailAddress(excel.ReadData(1, "FromMail"));
            //we are adding to mail id

            mail.To.Add(excel.ReadData(1, "ToMail"));
            //Subject of the mail is added
            mail.Subject = "Amazon test mail";
            //Body of the mail is added
            mail.Body = "mail with amazon report attachmement";
            Attachment attachment;
            attachment = new Attachment(@"C:\Users\HP\source\repos\AmazonApp\AmazonApp\Reports\index.html");
            Assert.NotNull(attachment);
            //here we attach the report of the automation
            mail.Attachments.Add(attachment);
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new NetworkCredential(excel.ReadData(1, "FromMail"), excel.ReadData(1, "Password"));
            SmtpServer.EnableSsl = true;
            //Here we click send mail 
            SmtpServer.Send(mail);
        }
    }
}
