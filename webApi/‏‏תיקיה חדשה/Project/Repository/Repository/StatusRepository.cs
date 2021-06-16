using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    class StatusRepository: IStatusRepository
    {
        DB context;
        public StatusRepository(DB context)//ההזרקה של לדטה בייס
        {
            this.context = context;
        }


        public void AddStatus(Status status)
        {
            context.Status.Add(status);
            context.SaveChanges();
        }

        public void DeleteStatus(Status status)
        {
            context.Status.Remove(status);
            context.SaveChanges();
        }

        public void UpdateStatus(Status status)
        {
            context.Status.Update(status);
            context.SaveChanges();
        }


        public List<Status> GetAllStatus()
        {

            return context.Status.ToList();
        }
    }
}
