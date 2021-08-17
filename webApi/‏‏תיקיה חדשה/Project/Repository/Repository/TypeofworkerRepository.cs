using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    class TypeofworkerRepository:ITypeofworkerRepository
    {
        DB context;
        public TypeofworkerRepository(DB context)
        {
            this.context = context;
        }


        public void AddTypeofworker(Typeofworker typeofworker)
        {
            context.Typeofworker.Add(typeofworker);
            context.SaveChanges();
        }

        public void DeleteTypeofworker(Typeofworker typeofworker)
        {
            context.Typeofworker.Update(typeofworker);
            context.SaveChanges();
        }

        public void UpdateTypeofworker(Typeofworker typeofworker)
        {
            context.Typeofworker.Remove(typeofworker);
            context.SaveChanges();
        }


        public List<Typeofworker> GetAllTypeofworker()
        {

            return context.Typeofworker.ToList();

        }


   
    }
}
