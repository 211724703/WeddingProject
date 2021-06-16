using Common;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class ValuestosadeofworkerService : IValuestosadeofworkerService
    {
        IValuestosadeofworkerRepository iValuesR;

        public ValuestosadeofworkerService(IValuestosadeofworkerRepository iValuesR)//גישה לרפוזיטורי
        {
            this.iValuesR = iValuesR;
        }
        public void AddValuestosadeofworker(CValuestosadeofworker valuesto)
        {
            //CBlocks cBlocks = new CBlocks() { IdBlock=block.IdBlock,NameBlocks=block.NameBlocks};
            Valuestosadeofworker valuestosadeofworker = new Valuestosadeofworker()
            {

                Valuestosadeofworkerid = valuesto.Valuestosadeofworkerid,//סיסמה
                Workerid = valuesto.Workerid,//שם משתמש
                Sadeid = valuesto.Sadeid,
                Value = valuesto.Value,

            };

            iValuesR.AddValuestosadeofworker(valuestosadeofworker);//זהו , זה ההוספה וככה את עושה גם למחיקה והעדכון אשלח לך דוגמא מפורטת
        }                            //עכשיו נעשה את הקונטרולר


        public void DeleteValuestosadeofworker(CValuestosadeofworker valuesto)
        {
            CValuestosadeofworker cvaluestosadeofworker = new CValuestosadeofworker()
            {

                Valuestosadeofworkerid = valuesto.Valuestosadeofworkerid,
                Workerid = valuesto.Workerid,
                Sadeid = valuesto.Sadeid,
                Value = valuesto.Value,

            };
            Valuestosadeofworker valuestosadeofworker = new Valuestosadeofworker()
            {

                Valuestosadeofworkerid = valuesto.Valuestosadeofworkerid,
                Workerid = valuesto.Workerid,
                Sadeid = valuesto.Sadeid,
                Value = valuesto.Value,

            };
            iValuesR.DeleteValuestosadeofworker(valuestosadeofworker);
        }

        public void UpdateValuestosadeofworker(CValuestosadeofworker valuesto)
        {
            CValuestosadeofworker cvaluestosadeofworker = new CValuestosadeofworker()
            {

                Valuestosadeofworkerid = valuesto.Valuestosadeofworkerid,
                Workerid = valuesto.Workerid,
                Sadeid = valuesto.Sadeid,
                Value = valuesto.Value,

            };


            Valuestosadeofworker valuestosadeofworker = new Valuestosadeofworker()
            {

                Valuestosadeofworkerid = valuesto.Valuestosadeofworkerid,
                Workerid = valuesto.Workerid,
                Sadeid = valuesto.Sadeid,
                Value = valuesto.Value,

            };
            iValuesR.DeleteValuestosadeofworker(valuestosadeofworker);
        }


        public List<CValuestosadeofworker> GetAllValuestosadeofworker()
        {
            List<CValuestosadeofworker> valuestosadeofworker = (from tmp in iValuesR.GetAllValuestosadeofworker()
                                                                select new CValuestosadeofworker
                                                                {
                                                                    Valuestosadeofworkerid = tmp.Valuestosadeofworkerid,
                                                                    Workerid = tmp.Workerid,
                                                                    Sadeid = tmp.Sadeid,
                                                                    Value = tmp.Value,
                                                                    

                                                                }).ToList();

            return valuestosadeofworker;
        }
        //מחזיר רשימת ערכים עפ"י קוד שדה
        public List<CValuestosadeofworker> GetValuestosadeofworkers(int Id)
        {
            List<CValuestosadeofworker> result = GetAllValuestosadeofworker().Where(a => a.Sadeid == Id).ToList();
            return result;
        }

        


        //לכל קוד שדה מחזיר את רשימת הערכים
        public List<CValuestosadeofworker> GetValuestosadeofworkersssss(List<Sadottypeofworker> ListSadeid)//מקבל רשימה של קוד שדה 
        {
            {
                List<Valuestosadeofworker> valuestosadeofworker = iValuesR.GetAllValuestosadeofworker();//גישה לרפוזיטורי
                List<CValuestosadeofworker> cvaluestosadeofworker = new List<CValuestosadeofworker>();
                foreach (var Sadeid in ListSadeid)  //השתמשנו בפור הנ"ל כי אין לנו גודל מוגדר של רשימה 
                {
                  //  cvaluestosadeofworker.Add(new CValuestosadeofworker { Valuestosadeofworkerid = Sadeid.Valuestosadeofworkerid, Company = Sadeid.Company, From = Sadeid.From, To = Sadeid.To });
                }
                return cvaluestosadeofworker;
            }
        }



        //public List<CFlight> GetCFlightsByCompany(int compId) //פונקציה שמחזירה את רשימת הטיסות של חברה מסוימת
        //{
        //    List<Flight> flights = flightRepository.GetFlightsByCompany(compId);//קישור לרפוזיטורי
        //    List<CFlight> cFlights = new List<CFlight>();//מקושר לקמממן
        //    foreach (var item in flights)
        //    {
        //        cFlights.Add(new CFlight { Id = item.Id, Company = item.Company, From = item.From, To = item.To });
        //    }

        //    return cFlights;
        //}
        //public List<CAppsAndWebsites> GetExpInBlock(int id)
        //{
        //    CAppsAndWebsites tmp;
        //    List<CAppsAndWebsites> appsAndWebsitesL = new List<CAppsAndWebsites>();
        //    List<CExceptionalAppsInBlocks> cExceptionalAppsInBlocksL = iExcAppInBlooks.GetAllExceptionalAppsInBlocks().Where(a => a.IdBlocks == id).ToList();
        //    foreach (CExceptionalAppsInBlocks item in cExceptionalAppsInBlocksL)
        //    {
        //        tmp = GetAppsAndWebsitesById(item.IdAppsAndWebsites);
        //        appsAndWebsitesL.Add(tmp);
        //    }
        //    return appsAndWebsitesL;
        //}

    }
}
