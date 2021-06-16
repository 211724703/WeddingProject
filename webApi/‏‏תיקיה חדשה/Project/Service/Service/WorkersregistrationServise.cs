using Common;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Service
{
    public class WorkersregistrationServise : IWorkersregistrationServise
    {
        IWorkersregistrationRepository iWorkersreR;

        public WorkersregistrationServise(IWorkersregistrationRepository iWorkersreR)//גישה לרפוזיטורי
        {
            this.iWorkersreR = iWorkersreR;
        }
        public void AddWorkersregistration(CWorkersregistration Worker)
        {
            //CBlocks cBlocks = new CBlocks() { IdBlock=block.IdBlock,NameBlocks=block.NameBlocks};
            Workersregistration workersregistration = new Workersregistration()
            {

                WorkersregistrationId = Worker.WorkersregistrationId,//סיסמה
                Dateworkersregistration = Worker.Dateworkersregistration,//שם משתמש
                Discreptionworkersregistration = Worker.Discreptionworkersregistration,
                Mailworker = Worker.Mailworker,
                Statusid = Worker.Statusid,
                NameworkersregistrationId= Worker.NameworkersregistrationId,
            };

            iWorkersreR.AddWorkersregistration(workersregistration);//זהו , זה ההוספה וככה את עושה גם למחיקה והעדכון אשלח לך דוגמא מפורטת
        }                            //עכשיו נעשה את הקונטרולר


        public void DeleteWorkersregistration(CWorkersregistration Worker)
        {
            CWorkersregistration cworkersregistration = new CWorkersregistration()
            {

                WorkersregistrationId = Worker.WorkersregistrationId,//סיסמה
                Dateworkersregistration = Worker.Dateworkersregistration,//שם משתמש
                Discreptionworkersregistration = Worker.Discreptionworkersregistration,
                Mailworker = Worker.Mailworker,
                Statusid = Worker.Statusid,
                NameworkersregistrationId = Worker.NameworkersregistrationId,
            };


            Workersregistration workersregistration = new Workersregistration()
            {

                WorkersregistrationId = Worker.WorkersregistrationId,//סיסמה
                Dateworkersregistration = Worker.Dateworkersregistration,//שם משתמש
                Discreptionworkersregistration = Worker.Discreptionworkersregistration,
                Mailworker = Worker.Mailworker,
                Statusid = Worker.Statusid,
                NameworkersregistrationId = Worker.NameworkersregistrationId,
            };
            iWorkersreR.DeleteWorkersregistration(workersregistration);
        }

        public void UpdateWorkersregistration(CWorkersregistration Worker)
        {

            CWorkersregistration cworkersregistration = new CWorkersregistration()
            {

                WorkersregistrationId = Worker.WorkersregistrationId,
                Dateworkersregistration = Worker.Dateworkersregistration,
                Discreptionworkersregistration = Worker.Discreptionworkersregistration,
                Mailworker = Worker.Mailworker,
                Statusid = Worker.Statusid,
                NameworkersregistrationId = Worker.NameworkersregistrationId,
            };


            Workersregistration workersregistration = new Workersregistration()
            {

                WorkersregistrationId = Worker.WorkersregistrationId,
                Dateworkersregistration = Worker.Dateworkersregistration,
                Discreptionworkersregistration = Worker.Discreptionworkersregistration,
                Mailworker = Worker.Mailworker,
                Statusid = Worker.Statusid,
                NameworkersregistrationId = Worker.NameworkersregistrationId,
            };
            iWorkersreR.DeleteWorkersregistration(workersregistration);
        }



        public List<CWorkersregistration> GetAllWorkersregistration()//מחזיר רשימה 
        {

            List<CWorkersregistration> workersregistration = (from tmp in iWorkersreR.GetAllWorkersregistration()
                                                              select new CWorkersregistration
                                                              {
                                                                  WorkersregistrationId = tmp.WorkersregistrationId,
                                                                  Dateworkersregistration = tmp.Dateworkersregistration,
                                                                  Discreptionworkersregistration = tmp.Discreptionworkersregistration,
                                                                  Mailworker = tmp.Mailworker,
                                                                  Statusid = tmp.Statusid,
                                                                  NameworkersregistrationId = tmp.NameworkersregistrationId,
                                                              }).ToList();

            return workersregistration;
        }
        //public void Sendemail(string to, string from, string path, string treename)
        //{
        //    MailMessage mail = new MailMessage();
        //    mail.To.Add(new MailAddress(to));
        //    mail.From = new MailAddress(from);
        //    mail.Subject = "בהמשך לפנייתך ל" + treename;
        //    Attachment attachment = new Attachment(path);
        //    mail.Attachments.Add(attachment);
        //    try
        //    {
        //        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        //        smtp.UseDefaultCredentials = false;
        //        smtp.Credentials = new System.Net.NetworkCredential("smart.nevigation");
        //    }
        //}

    }
}
