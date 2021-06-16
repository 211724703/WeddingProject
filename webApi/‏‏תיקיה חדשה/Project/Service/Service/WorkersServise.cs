using Common;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Service
{
    public class WorkersServise : IWorkersServise
    {
        IWorkersRepository iWorkeR;
        IValuestosadeofworkerRepository iValuesR;
        ISadottypeofworkerRepository iSadottypR;

        public WorkersServise(IWorkersRepository iWorkeR, IValuestosadeofworkerRepository iValuesR, ISadottypeofworkerRepository iSadottypR)//גישה לרפוזיטורי
        {
            this.iWorkeR = iWorkeR;
            this.iValuesR = iValuesR;
            this.iSadottypR = iSadottypR;
        }
        public void AddWorkers(CWorkers Work)
        {
            //CBlocks cBlocks = new CBlocks() { IdBlock=block.IdBlock,NameBlocks=block.NameBlocks};
            Workers workers = new Workers()
            {

                Workerid = Work.Workerid,
                Nameworker = Work.Nameworker,
                Selfphone = Work.Selfphone,
                Description = Work.Description,
                Mailworker = Work.Mailworker,
                Typeid = Work.Typeid,
                //Image = Work.Image,
            };

            iWorkeR.AddWorkers(workers);//זהו , זה ההוספה וככה את עושה גם למחיקה והעדכון אשלח לך דוגמא מפורטת
        }                            //עכשיו נעשה את הקונטרולר


        public void DeleteWorkers(CWorkers Work)  //מחיקת לקוח
        {
            CWorkers cworkers = new CWorkers()
            {

                Workerid = Work.Workerid,
                Nameworker = Work.Nameworker,
                Selfphone = Work.Selfphone,
                Description = Work.Description,
                Mailworker = Work.Mailworker,
                Typeid = Work.Typeid,
                Image = Work.Image,
            };
            Workers workers = new Workers()
            {

                Workerid = Work.Workerid,
                Nameworker = Work.Nameworker,
                Selfphone = Work.Selfphone,
                Description = Work.Description,
                Mailworker = Work.Mailworker,
                Typeid = Work.Typeid,
                Image = Work.Image,
            };
            iWorkeR.DeleteWorkers(workers);
        }

        public void UpdateWorkers(CWorkers Work)
        {
            CWorkers cworkers = new CWorkers()
            {

                Workerid = Work.Workerid,
                Nameworker = Work.Nameworker,
                Selfphone = Work.Selfphone,
                Description = Work.Description,
                Mailworker = Work.Mailworker,
                Typeid = Work.Typeid,
                Image = Work.Image,
            };
            Workers workers = new Workers()
            {

                Workerid = Work.Workerid,
                Nameworker = Work.Nameworker,
                Selfphone = Work.Selfphone,
                Description = Work.Description,
                Mailworker = Work.Mailworker,
                Typeid = Work.Typeid,
                Image = Work.Image,
            };
            iWorkeR.UpdateWorkers(workers);
        }



        public List<CWorkers> GetAllWorkers()//מחזיר רשימה 
        {

            List<CWorkers> Workers = (from tmp in iWorkeR.GetAllWorkers()
                                      select new CWorkers
                                      {
                                          Workerid = tmp.Workerid,
                                          Nameworker = tmp.Nameworker,
                                          Selfphone = tmp.Selfphone,
                                          Description = tmp.Description,
                                          Mailworker = tmp.Mailworker,
                                          Typeid = tmp.Typeid,
                                          Image = tmp.Image,

                                      }).ToList();

            return Workers;
        }

        ////שליפת בעל מקצוע לפי סוג

        public List<CWorkers> Getworker(int Id)
        {
            List<CWorkers> result = GetAllWorkers().Where(a => a.Typeid == Id).ToList(); //מחזיר רשימה של בעלי מקצוע מסוים(זמרים  לדוגמא יונתן שיינפלד,אמירן דביר  ןכן'...)
            return result;
        }

        public void Getworkes()
        {
            throw new NotImplementedException();
        }


        //שליפת בעל מקצוע עפ"י שם
        public CWorkers GetworkerByName(string name)
        {
            CWorkers result = GetAllWorkers().FirstOrDefault(a => a.Nameworker == name); //מחזיר רשימה של בעלי מקצוע מסוים(זמרים  לדוגמא יונתן שיינפלד,אמירן דביר  ןכן'...)
            return result;
        }


        //מקבלת קוד סוג בעל מקצוע מסוים ומחזירה את הפרטים+מחיר////////////////////////////////////////////////////////////////
        //מחזיר רק אחד ולא רשימה???
        //public object[] GetDetailsWorker(int Id)///לישאול על סוג ההחזרה וכו
        //{
        //                                                                   //קישור בין הטבלאות בעלי מקצוע ,השדות ,הערכים
        //     var  DetailsWorker = new[] {(from tmp in iWorkeR.GetAllWorkers() join tmp1 in iValuesR.GetAllValuestosadeofworker()
        //                              on tmp.Workerid equals tmp1.Workerid join tmp2 in iSadottypR.GetAllSadottypeofworker()
        //                              on tmp1.Sadeid equals tmp2.Sadeid
        //                              where tmp.Typeid == Id  //בדיקה שבעל המקצוע הוא מסוג שירות מסוים
        //                              where tmp2.Sadetypeid ==2//בדיקה שהשדה הוא מחיר
        //                              select new CWorkers
        //                              {
        //                                  Nameworker = tmp.Nameworker,
        //                                  Selfphone = tmp.Selfphone,
        //                                  Description = tmp.Description,
        //                                  Mailworker = tmp.Mailworker,
        //                                  //image = tmp.image,
        //                                  price = tmp1.Value,/////לעשות  F12 על הווליו ולישאול אם זה טוב         
        //                                  //איך בדיוק להביא את המחיר
        //                              }).ToList() };

        //    return DetailsWorker;
        //}
        /// <summary>
        /// ////////////////////////////////////פונקציה טובה לבדוק
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        //public object[] GetDetailsWorker(int Id)///לישאול על סוג ההחזרה וכו
        //{
        //    //var a = iSadottypR.GetAllSadottypeofworker().Where(t=>t.Typeid==Id).ToList();
        //    //var res =(from tmp in iWorkeR.GetAllWorkers()
        //    //           join tmp1 in iSadottypR.GetAllSadottypeofworker() on tmp.Typeid equals tmp1.Typeid
        //    //           where tmp.Typeid == Id
        //    //           select new CWorkers
        //    //           {
        //    //               Nameworker = tmp.Nameworker,
        //    //               Selfphone = tmp.Selfphone,
        //    //               Description = tmp.Description,
        //    //               Mailworker = tmp.Mailworker,
        //    //               Image = tmp.Image
        //    //           }).ToList() ;



        //    // קישור בין הטבלאות בעלי מקצוע ,השדות ,הערכים
        //    var res = (from tmp in iWorkeR.GetAllWorkers()
        //               join tmp1 in iValuesR.GetAllValuestosadeofworker()
        //               on tmp.Workerid equals tmp1.Workerid
        //               join tmp2 in iSadottypR.GetAllSadottypeofworker()
        //               on tmp1.Sadeid equals tmp2.Sadeid
        //               where tmp.Typeid == Id  //בדיקה שבעל המקצוע הוא מסוג שירות מסוים
        //               where tmp2.Sadetypeid == 2//בדיקה שהשדה הוא מחיר
        //               group tmp by tmp.Workerid into gr
        //               select gr
        //                              ).ToList();
        //    object[] DetailsWorker = new object[res.Count()];
        //    CWorkers temp;
        //    int i = 0;
        //    foreach (var gr in res)
        //    {
        //        temp = new CWorkers { Workerid = gr.Key };
        //        foreach (var item in gr)
        //        {
        //            temp.Nameworker = item.Nameworker;
        //            temp.Selfphone = item.Selfphone;
        //            temp.Description = item.Description;
        //            temp.Mailworker = item.Mailworker;
        //            temp.Image = item.Image;
        //            temp.Values = new List<string>();
        //            foreach (var sade in item.Valuestosadeofworker)
        //            {
        //                temp.Values.Add(sade.Value);

        //            }

        //        }
        //        DetailsWorker[i] = temp;
        //    }


        //    //new CWorkers
        //    //                          {
        //    //                              Nameworker = tmp.Nameworker,
        //    //                              Selfphone = tmp.Selfphone,
        //    //                              Description = tmp.Description,
        //    //                              Mailworker = tmp.Mailworker,
        //    //                              Image = tmp.Image,
        //    //                              price = tmp1.Value,
        //    //                              category = tmp1.Value,//קטגוריה 
        //    //                              aria = tmp1.Value,//אזור
        //    //                              janner = tmp1.Value,//זאנר

        //    //                          }).ToList() };

        //    return DetailsWorker;


        ////ישן 
        public object[] GetDetailsWorkerByType(int Id)///לישאול על סוג ההחזרה וכו
        {

            var DetailsWorker = (from tmp in iWorkeR.GetAllWorkers()
                                 where tmp.Typeid == Id  //בדיקה שבעל המקצוע הוא מסוג שירות מסוים
                                 select new CWorkers
                                 {
                                     Workerid = tmp.Workerid,
                                     Nameworker = tmp.Nameworker,
                                     Selfphone = tmp.Selfphone,
                                     Description = tmp.Description,
                                     Mailworker = tmp.Mailworker,
                                     Typeid = tmp.Typeid,
                                     Image = tmp.Image,
                                 }).ToList();

            var sadotType = iSadottypR.GetAllSadottypeofworker();
            foreach (var item in DetailsWorker)
            {
                var sadot = iSadottypR.GetAllSadottypeofworker().Where(x => x.Typeid == item.Typeid);
                if (sadot.Any())
                {
                    var values = iValuesR.GetAllValuestosadeofworker().Where(x => sadot.Any(y => y.Typeid == x.Sadeid) && x.Workerid == item.Workerid);
                    if (values.Any())
                    {
                        item.ExtraValues = new List<KeyValuePair<string, string>>();
                        foreach (var v in values)
                        {
                            var sade = sadotType.FirstOrDefault(x => x.Sadeid == v.Sadeid);
                            item.ExtraValues.Add(new KeyValuePair<string, string>(sade.Sadename, v.Value));
                        }
                    }
                }
            }

            return DetailsWorker.ToArray();
        }


        //public object[] GetDetailsWorkerByType(int Id)///לישאול על סוג ההחזרה וכו
        //{

        //    var DetailsWorker = (from tmp in iWorkeR.GetAllWorkers()
        //                         where tmp.Typeid == Id  //בדיקה שבעל המקצוע הוא מסוג שירות מסוים
        //                         select new CWorkers
        //                         {
        //                             Workerid = tmp.Workerid,
        //                             Nameworker = tmp.Nameworker,
        //                             Selfphone = tmp.Selfphone,
        //                             Description = tmp.Description,
        //                             Mailworker = tmp.Mailworker,
        //                             Typeid = tmp.Typeid,
        //                         }).ToList();

        //    var sadotType = iSadottypR.GetAllSadottypeofworker();
        //    foreach (var item in DetailsWorker)
        //    {
        //        var sadot = iSadottypR.GetAllSadottypeofworker().Where(x => x.Typeid == item.Typeid);
        //        if (sadot.Any())
        //        {
        //            var values = iValuesR.GetAllValuestosadeofworker().Where(x => sadot.Any(y => y.Sadetypeid == x.Sadeid) && x.Workerid == item.Workerid);
        //            if (values.Any())
        //            {
        //                item.ExtraValues = new List<KeyValuePair<string, string>>();
        //                foreach (var v in values)
        //                {
        //                    var sade = sadotType.FirstOrDefault(x => x.Sadeid == v.Sadeid);
        //                    item.ExtraValues.Add(new KeyValuePair<string, string>(sade.Sadename, v.Value));
        //                }
        //            }
        //        }
        //    }

        //    return DetailsWorker.ToArray();
        //}
        public object GetDetailsWorkerById(int Id)///המקורי
        {

            var DetailsWorker = (from tmp in iWorkeR.GetAllWorkers()
                                 where tmp.Workerid == Id
                                 select new CWorkers
                                 {
                                     Workerid = tmp.Workerid,
                                     Nameworker = tmp.Nameworker,
                                     Selfphone = tmp.Selfphone,
                                     Description = tmp.Description,
                                     Mailworker = tmp.Mailworker,
                                     Typeid = tmp.Typeid,
                                 }).ToList();

            var sadotType = iSadottypR.GetAllSadottypeofworker();
            foreach (var item in DetailsWorker)
            {
                var sadot = iSadottypR.GetAllSadottypeofworker().Where(x => x.Typeid == item.Typeid);
                if (sadot.Any())
                {
                    var values = iValuesR.GetAllValuestosadeofworker().Where(x => sadot.Any(y => y.Sadeid == x.Sadeid) && x.Workerid == item.Workerid);
                    if (values.Any())
                    {
                        item.ExtraValues = new List<KeyValuePair<string, string>>();
                        foreach (var v in values)
                        {
                            var sade = sadotType.FirstOrDefault(x => x.Sadeid == v.Sadeid);
                            item.ExtraValues.Add(new KeyValuePair<string, string>(sade.Sadename, v.Value));
                        }
                    }
                }
            }

            return DetailsWorker.FirstOrDefault();
        }

        //public object GetDetailsWorkerById(int Id)///לישאול על סוג ההחזרה וכו
        //{

        //    //var detailsWorker = (from tmp in iWorkeR.GetAllWorkers()
        //    //                     where tmp.Workerid == Id
        //    //                     select new CWorkers
        //    //                     {
        //    //                         Workerid = tmp.Workerid,
        //    //                         Nameworker = tmp.Nameworker,
        //    //                         Selfphone = tmp.Selfphone,
        //    //                         Description = tmp.Description,
        //    //                         Mailworker = tmp.Mailworker,
        //    //                         Typeid = tmp.Typeid,
        //    //                     }).ToList()[0];

        //    //var sadotType = iSadottypR.GetAllSadottypeofworker().Where(x => x.Typeid == detailsWorker.Typeid).ToList();
        //    //foreach (var item in sadotType)
        //    //{
        //    //    var values = iValuesR.GetAllValuestosadeofworker().Where(e => e.Sadeid)
        //    //}

        //    //return null;
        //}

        public object[] GetinformWorker(int tId, int wId)///לישאול על סוג ההחזרה וכו
        {

            var DetailsWorker = new[] {(from tmp in iWorkeR.GetAllWorkers() join tmp1 in iValuesR.GetAllValuestosadeofworker()
                                      on tmp.Workerid equals tmp1.Workerid join tmp2 in iSadottypR.GetAllSadottypeofworker()
                                      on tmp1.Sadeid equals tmp2.Sadeid
                                      where tmp.Typeid == tId //בדיקה שבעל המקצוע הוא מסוג שירות מסוים
                                      where tmp.Workerid == wId  
                                     // where tmp2.Sadetypeid ==2//בדיקה שהשדה הוא מחיר
                                      select new CWorkers
                                      {
                                          Workerid = tmp.Workerid,
                                          Nameworker = tmp.Nameworker,
                                          Selfphone = tmp.Selfphone,
                                          Description = tmp.Description,
                                          Mailworker = tmp.Mailworker,
                                          Image = tmp.Image,
                                          price = tmp1.Value,
                                          category = tmp1.Value,//קטגוריה 
                                          aria = tmp1.Value,//אזור
                                          janner = tmp1.Value,//זאנר
                                      }).ToList() };

            return DetailsWorker;
        }
        ////פונקציה המקבלת ערך וקוד בעל מקצוע ומחזירה את רשימת בעלי המקצוע  שארכם שווה לערך הנתון
        //public List<CWorkers> Getfilterlist(int workid ,string Valueofworker)
        //{
        //    List<CWorkers> result = (from tmp in iWorkeR.GetAllWorkers()
        //                             join tmp1 in iValuesR.GetAllValuestosadeofworker() on tmp.Workerid equals tmp1.Workerid
        //                             where tmp.Workerid == workid && tmp1.Value == Valueofworker);

        //    return result;
        //}

        //public List<CWorkers> Getfilterlist(int workid, string Valueofworker)
        //{
        //    List<CWorkers> result = GetAllWorkers().Where(a => a.Workerid == workid && iValuesR.GetAllValuestosadeofworker().Where (a=>iValuesR //מחזיר רשימה של בעלי מקצוע מסוים(זמרים  לדוגמא יונתן שיינפלד,אמירן דביר  ןכן'...)
        //    return result;
        //    ;

        //    return result;
        //}



        //    return typeofworker;
        //}
        ////    שליפת בעל מקצוע לפי ערכים
        //public List<CWorkers> Getworkes(List<Valuestosadeofworker> Listvalues)//מקבל רשימה של ערכים
        //{
        //    List<Workers> workers = iWorkeR.GetAllWorkers();//גישה לרפוזיטורי
        //    List<CWorkers> cWorkers = new List<CWorkers>();
        //    foreach (var Workerid in Listvalues)
        //    {
        //          cWorkers.Add(new CWorkers { Workerid = Workerid.Workerid });
        //    }
        //    return cWorkers;
        //}


    }
}


