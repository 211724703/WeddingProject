using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
   public class WorkersRepository: IWorkersRepository
    {
        DB context;
        public WorkersRepository(DB context)
        {
            this.context = context;
        }


        public void AddWorkers(Workers workers)
        {
            context.Workers.Add(workers);
            context.SaveChanges();
        }

        public void DeleteWorkers(Workers workers)
        {
            context.Workers.Remove(workers);
            context.SaveChanges();
        }

        public void UpdateWorkers(Workers workers)
        {
            context.Workers.Update(workers);
            context.SaveChanges();
        }


        public List<Workers> GetAllWorkers()
        {

            return context.Workers.ToList();
        }
    }
}

