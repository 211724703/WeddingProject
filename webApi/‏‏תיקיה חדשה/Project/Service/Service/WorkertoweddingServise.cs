 using Common;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class WorkertoweddingServise : IWorkertoweddingServise
    {
        IWorkertoweddingRepository iWorker;

        public WorkertoweddingServise(IWorkertoweddingRepository iWorker)//גישה לרפוזיטורי
        {
            this.iWorker = iWorker;
        }

        public void AddWorkertowedding(CWorkertowedding Workert)
        {
            Workertowedding workertowedding = new Workertowedding()///זה טבלת קישור לברר
            {
                Workertoweddingid = Workert.Workertoweddingid,
                Workerid = Workert.Workerid,
                Userid = Workert.Userid,
                Statusid = Workert.Statusid,
            };
            iWorker.AddWorkertowedding(workertowedding);

        }

        public void DeleteWorkertowedding(CWorkertowedding Workert)//
        {
            CWorkertowedding cworkertowedding = new CWorkertowedding()///זה טבלת קישור לברר
            {
                Workertoweddingid = Workert.Workertoweddingid,
                Workerid = Workert.Workerid,
                Userid = Workert.Userid,  
                Statusid = Workert.Statusid,
            };
        Workertowedding workertowedding = new Workertowedding()///זה טבלת קישור לברר
        {
            Workertoweddingid = Workert.Workertoweddingid,
            Workerid = Workert.Workerid,
            Userid = Workert.Userid,
            Statusid = Workert.Statusid,
        };
        iWorker.DeleteWorkertowedding(workertowedding);

        }

    public void UpdateWorkertowedding(CWorkertowedding Workert)
    {
            CWorkertowedding cworkertowedding = new CWorkertowedding()///זה טבלת קישור לברר
            {
                Workertoweddingid = Workert.Workertoweddingid,
                Workerid = Workert.Workerid,
                Userid = Workert.Userid,
                Statusid = Workert.Statusid,
            };
            Workertowedding workertowedding = new Workertowedding()///זה טבלת קישור לברר
            {
                Workertoweddingid = Workert.Workertoweddingid,
                Workerid = Workert.Workerid,
                Userid = Workert.Userid,
                Statusid = Workert.Statusid,
            };
            iWorker.UpdateWorkertowedding(workertowedding);
    }



    public List<CWorkertowedding> GetAllWorkertowedding()//מחזיר רשימה 
    {

        List<CWorkertowedding> Workertowedding = (from tmp in iWorker.GetAllWorkertowedding()
                                                  select new CWorkertowedding
                                                  {
                                                      Workertoweddingid = tmp.Workertoweddingid,
                                                      Workerid = tmp.Workerid,
                                                      Userid = tmp.Userid,
                                                      Statusid = tmp.Statusid,

                                                  }).ToList();

        return Workertowedding;
    }



}
}
