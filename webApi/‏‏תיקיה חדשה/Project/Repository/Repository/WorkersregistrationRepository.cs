using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    class WorkersregistrationRepository: IWorkersregistrationRepository
    {
        DB context;
        public WorkersregistrationRepository(DB context)
        {
            this.context = context;
        }


        public void AddWorkersregistration(Workersregistration workersregistration)
        {
            context.Workersregistration.Add(workersregistration);
            context.SaveChanges();
        }

        public void DeleteWorkersregistration(Workersregistration workersregistration)
        {
            context.Workersregistration.Remove(workersregistration);
            context.SaveChanges();
        }

        public void UpdateWorkersregistration(Workersregistration workersregistration)
        {
            context.Workersregistration.Update(workersregistration);
            context.SaveChanges();
        }


        public List<Workersregistration> GetAllWorkersregistration()
        {

            return context.Workersregistration.ToList();
        }
    }
}
