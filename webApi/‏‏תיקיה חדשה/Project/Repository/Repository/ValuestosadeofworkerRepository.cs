using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    class ValuestosadeofworkerRepository : IValuestosadeofworkerRepository
    {
        DB context;
        public ValuestosadeofworkerRepository(DB context)
        {
            this.context = context;
        }


        public void AddValuestosadeofworker(Valuestosadeofworker valuestosadeofworker)
        {
            context.Valuestosadeofworker.Add(valuestosadeofworker);
            context.SaveChanges();
        }

        public void DeleteValuestosadeofworker(Valuestosadeofworker valuestosadeofworker)
        {
            context.Valuestosadeofworker.Remove(valuestosadeofworker);
            context.SaveChanges();
        }

        public void UpdateValuestosadeofworker(Valuestosadeofworker valuestosadeofworker)
        {
            context.Valuestosadeofworker.Update(valuestosadeofworker);
            context.SaveChanges();
        }


        public List<Valuestosadeofworker> GetAllValuestosadeofworker()
        {

            return context.Valuestosadeofworker.ToList();
        }
    }
}

