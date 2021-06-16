using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    class SadottypeofworkerRepository:ISadottypeofworkerRepository
    {
        DB context;
        public SadottypeofworkerRepository(DB context)//ההזרקה של לדטה בייס
        {
            this.context = context;
        }


        public void AddSadottypeofworker(Sadottypeofworker sadottypeofworker)
        {
            context.Sadottypeofworker.Add(sadottypeofworker);
            context.SaveChanges();
        }

        public void DeleteSadottypeofworker(Sadottypeofworker sadottypeofworker)
        {
            context.Sadottypeofworker.Remove(sadottypeofworker);
            context.SaveChanges();
        }

        public void UpdateSadottypeofworker(Sadottypeofworker sadottypeofworker)
        {
            context.Sadottypeofworker.Update(sadottypeofworker);
            context.SaveChanges();
        }


        public List<Sadottypeofworker> GetAllSadottypeofworker()
        {

            return context.Sadottypeofworker.ToList();
        }
    }
}
