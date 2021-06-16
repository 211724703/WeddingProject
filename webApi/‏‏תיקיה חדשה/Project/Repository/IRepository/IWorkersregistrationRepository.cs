using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IWorkersregistrationRepository
    {
        void AddWorkersregistration(Workersregistration workersregistration);
        void DeleteWorkersregistration(Workersregistration workersregistration);
        void UpdateWorkersregistration(Workersregistration workersregistration);
        List<Workersregistration> GetAllWorkersregistration();
    }
}
