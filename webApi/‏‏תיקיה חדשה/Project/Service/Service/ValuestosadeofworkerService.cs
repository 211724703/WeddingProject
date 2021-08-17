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

        public ValuestosadeofworkerService(IValuestosadeofworkerRepository iValuesR)
        {
            this.iValuesR = iValuesR;
        }
        public void AddValuestosadeofworker(CValuestosadeofworker valuesto)
        {
    
            Valuestosadeofworker valuestosadeofworker = new Valuestosadeofworker()
            {

                Valuestosadeofworkerid = valuesto.Valuestosadeofworkerid,
                Workerid = valuesto.Workerid,
                Sadeid = valuesto.Sadeid,
                Value = valuesto.Value,

            };

            iValuesR.AddValuestosadeofworker(valuestosadeofworker);
        }                            


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
        
        public List<CValuestosadeofworker> GetValuestosadeofworkers(int Id)
        {
            List<CValuestosadeofworker> result = GetAllValuestosadeofworker().Where(a => a.Sadeid == Id).ToList();
            return result;
        }

        


        
        public List<CValuestosadeofworker> GetValuestosadeofworkersssss(List<Sadottypeofworker> ListSadeid)
        {
            {
                List<Valuestosadeofworker> valuestosadeofworker = iValuesR.GetAllValuestosadeofworker();
                List<CValuestosadeofworker> cvaluestosadeofworker = new List<CValuestosadeofworker>();
                foreach (var Sadeid in ListSadeid)  
                {
                  //  cvaluestosadeofworker.Add(new CValuestosadeofworker { Valuestosadeofworkerid = Sadeid.Valuestosadeofworkerid, Company = Sadeid.Company, From = Sadeid.From, To = Sadeid.To });
                }
                return cvaluestosadeofworker;
            }
        }



     
    }
}
