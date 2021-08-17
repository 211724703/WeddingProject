using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
     public  class SadottypeRepository:ISadottypeRepository
    {

        DB context;
       public SadottypeRepository(DB context)
        {
            this.context = context;
        }


        public void AddSadottype(Sadottype sadottype)
        {
            context.Sadottype.Add(sadottype);
            context.SaveChanges();
        }

        public void DeleteSadottype(Sadottype sadottype)
        {
            context.Sadottype.Remove(sadottype);
            context.SaveChanges();
        }

        public void UpdateSadottype(Sadottype sadottype)
        {
            context.Sadottype.Update(sadottype);
            context.SaveChanges();
        }


        public List<Sadottype> GetAllSadottype()
        {

            return context.Sadottype.ToList();
        }
    }
}
