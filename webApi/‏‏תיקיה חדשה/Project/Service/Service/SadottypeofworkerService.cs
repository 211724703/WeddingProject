using Common;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    class SadottypeofworkerService : ISadottypeofworkerService
    {
        ISadottypeofworkerRepository iSadottypR;

        public SadottypeofworkerService(ISadottypeofworkerRepository iSadottypR)
        
            this.iSadottypR = iSadottypR;
        }
        public void AddSadottypeofworker(CSadottypeofworker Sadot)
        {
            //CBlocks cBlocks = new CBlocks() { IdBlock=block.IdBlock,NameBlocks=block.NameBlocks};
            Sadottypeofworker sadottypeofworker = new Sadottypeofworker()
            {

                Sadeid = Sadot.Sadeid,
                Sadename = Sadot.Sadename,
                Typeid = Sadot.Typeid,
                Sadetypeid = Sadot.Sadetypeid,
            };

            iSadottypR.AddSadottypeofworker(sadottypeofworker);
        }


        public void DeleteSadottypeofworker(CSadottypeofworker Sadot)
        {
            CSadottypeofworker csadottypeofworker = new CSadottypeofworker()
            {
                Sadeid = Sadot.Sadeid,
                Sadename = Sadot.Sadename,
                Typeid = Sadot.Typeid,
                Sadetypeid = Sadot.Sadetypeid,
            };
            Sadottypeofworker sadottypeofworker = new Sadottypeofworker()
            {
                Sadeid = Sadot.Sadeid,
                Sadename = Sadot.Sadename,
                Typeid = Sadot.Typeid,
                Sadetypeid = Sadot.Sadetypeid,
            };
            iSadottypR.DeleteSadottypeofworker(sadottypeofworker);
        }

        public void UpdateSadottypeofworker(CSadottypeofworker Sadot)
        {
            CSadottypeofworker csadottypeofworker = new CSadottypeofworker()
            {
                Sadeid = Sadot.Sadeid,
                Sadename = Sadot.Sadename,
                Typeid = Sadot.Typeid,
                Sadetypeid = Sadot.Sadetypeid,
            };
            Sadottypeofworker sadottypeofworker = new Sadottypeofworker()
            {
                Sadeid = Sadot.Sadeid,
                Sadename = Sadot.Sadename,
                Typeid = Sadot.Typeid,
                Sadetypeid = Sadot.Sadetypeid,
            };
            iSadottypR.UpdateSadottypeofworker(sadottypeofworker);
        }



        public List<CSadottypeofworker> GetAllSadottypeofworker()
        {

            List<CSadottypeofworker> sadottypeofworker = (from tmp in iSadottypR.GetAllSadottypeofworker()
                                          select new CSadottypeofworker
                                          {
                                              Sadeid = tmp.Sadeid,
                                              Sadename = tmp.Sadename,
                                              Typeid = tmp.Typeid,
                                              Sadetypeid = tmp.Sadetypeid,

                                          }).ToList();

            return sadottypeofworker;
        }
        
        public List<CSadottypeofworker> GetSadotType(int Id)
        {
            List<CSadottypeofworker> result = GetAllSadottypeofworker().Where(a => a.Typeid == Id).ToList();
            return result;
        }

    }

}
