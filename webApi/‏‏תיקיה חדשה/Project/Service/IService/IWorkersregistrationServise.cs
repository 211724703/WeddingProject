using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
  public  interface IWorkersregistrationServise
    {
        void AddWorkersregistration(CWorkersregistration Worker);
        void DeleteWorkersregistration(CWorkersregistration Worker);
        void UpdateWorkersregistration(CWorkersregistration Worker);
        List<CWorkersregistration> GetAllWorkersregistration();

    }
}
