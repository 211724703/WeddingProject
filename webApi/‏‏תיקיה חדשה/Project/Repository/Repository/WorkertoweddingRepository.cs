using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    class WorkertoweddingRepository: IWorkertoweddingRepository
    {
        DB context;
        public WorkertoweddingRepository(DB context)//ההזרקה של לדטה בייס
        {
            this.context = context; 
        }


        public void AddWorkertowedding(Workertowedding workertowedding)
        {
            context.Workertowedding.Add(workertowedding);
            context.SaveChanges();
        }

        public void DeleteWorkertowedding(Workertowedding workertowedding)
        {
            context.Workertowedding.Remove(workertowedding);
            context.SaveChanges();
        }

        public void UpdateWorkertowedding(Workertowedding workertowedding)
        {
            context.Workertowedding.Update(workertowedding);
            context.SaveChanges();
        }


        public List<Workertowedding> GetAllWorkertowedding()
        {

            return context.Workertowedding.ToList();
        }
    }
}

