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

        public WorkersregistrationServise(IWorkersregistrationRepository iWorkersreR)
        {
            this.iWorkersreR = iWorkersreR;
        }
        public void AddWorkersregistration(CWorkersregistration Worker)
        {
            
            Workersregistration workersregistration = new Workersregistration()
            {

                WorkersregistrationId = Worker.WorkersregistrationId,
                Dateworkersregistration = Worker.Dateworkersregistration,
                Discreptionworkersregistration = Worker.Discreptionworkersregistration,
                Mailworker = Worker.Mailworker,
                Statusid = Worker.Statusid,
                NameworkersregistrationId= Worker.NameworkersregistrationId,
            };

            iWorkersreR.AddWorkersregistration(workersregistration);
            }


        public void DeleteWorkersregistration(CWorkersregistration Worker)
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



        public List<CWorkersregistration> GetAllWorkersregistration()
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
     

    }
}
