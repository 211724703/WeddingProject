using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
  public  interface ISadottypeofworkerService
    {
        void AddSadottypeofworker(CSadottypeofworker Sadot);
        void DeleteSadottypeofworker(CSadottypeofworker Sadot);
        void UpdateSadottypeofworker(CSadottypeofworker Sadot);
        List<CSadottypeofworker> GetAllSadottypeofworker();
        List<CSadottypeofworker> GetSadotType(int Id);
    }
}

