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

        public WorkersServise(IWorkersRepository iWorkeR, IValuestosadeofworkerRepository iValuesR, ISadottypeofworkerRepository iSadottypR)
        {
            this.iWorkeR = iWorkeR;
            this.iValuesR = iValuesR;
            this.iSadottypR = iSadottypR;
        }
        public void AddWorkers(CWorkers Work)
        {

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

            iWorkeR.AddWorkers(workers);
        }                            

        public void DeleteWorkers(CWorkers Work)  
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



        public List<CWorkers> GetAllWorkers()
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

        
        public List<CWorkers> Getworker(int Id)
        {
            List<CWorkers> result = GetAllWorkers().Where(a => a.Typeid == Id).ToList(); 
            return result;
        }

        public void Getworkes()
        {
            throw new NotImplementedException();
        }


        
        public CWorkers GetworkerByName(string name)
        {
            CWorkers result = GetAllWorkers().FirstOrDefault(a => a.Nameworker == name); 
            return result;
        }


        public object[] GetDetailsWorkerByType(int Id)
        {

            var DetailsWorker = (from tmp in iWorkeR.GetAllWorkers()
                                 where tmp.Typeid == Id  
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


        public object GetDetailsWorkerById(int Id)
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

     

        public object[] GetinformWorker(int tId, int wId)
        {

            var DetailsWorker = new[] {(from tmp in iWorkeR.GetAllWorkers() join tmp1 in iValuesR.GetAllValuestosadeofworker()
                                      on tmp.Workerid equals tmp1.Workerid join tmp2 in iSadottypR.GetAllSadottypeofworker()
                                      on tmp1.Sadeid equals tmp2.Sadeid
                                      where tmp.Typeid == tId 
                                      where tmp.Workerid == wId 
                                      select new CWorkers
                                      {
                                          Workerid = tmp.Workerid,
                                          Nameworker = tmp.Nameworker,
                                          Selfphone = tmp.Selfphone,
                                          Description = tmp.Description,
                                          Mailworker = tmp.Mailworker,
                                          Image = tmp.Image,
                                          price = tmp1.Value,
                                          category = tmp1.Value,
                                          aria = tmp1.Value,
                                          janner = tmp1.Value,
                                      }).ToList() };

            return DetailsWorker;
        }
    


    }
}


