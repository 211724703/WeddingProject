using Common;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class StatusService : IStatusServicecs
    {
        IStatusRepository iStatusR;

        public StatusService(IStatusRepository iStatusR)//גישה לרפוזיטורי
        {
            this.iStatusR = iStatusR;
        }
        public void AddStatus(CStatus Stat)
        {
            //CBlocks cBlocks = new CBlocks() { IdBlock=block.IdBlock,NameBlocks=block.NameBlocks};
            Status status = new Status()
            {

                Statusid = Stat.Statusid,
                Statusname = Stat.Statusname,
            };

            iStatusR.AddStatus(status);//זהו , זה ההוספה וככה את עושה גם למחיקה והעדכון אשלח לך דוגמא מפורטת
        }                            //עכשיו נעשה את הקונטרולר


        public void DeleteStatus(CStatus Stat)
        {
            CStatus cstatus = new CStatus()
            {

                Statusid = Stat.Statusid,
                Statusname = Stat.Statusname,
            };

            Status status = new Status()
            {

                Statusid = Stat.Statusid,
                Statusname = Stat.Statusname,
            };
            iStatusR.DeleteStatus(status);
        }

        public void UpdateStatus(CStatus Stat)
        {
            CStatus cstatus = new CStatus()
            {

                Statusid = Stat.Statusid,
                Statusname = Stat.Statusname,
            };

            Status status = new Status()
            {

                Statusid = Stat.Statusid,
                Statusname = Stat.Statusname,
            };
            iStatusR.UpdateStatus(status);
        }



        public List<CStatus> GetAllStatus()//מחזיר רשימה 
        {

            List<CStatus> Status = (from tmp in iStatusR.GetAllStatus()
                                    select new CStatus
                                    {

                                        Statusid = tmp.Statusid,
                                        Statusname = tmp.Statusname,
                                    }).ToList();

            return Status;
        }

    }

}
