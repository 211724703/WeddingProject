using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface ISadottypeofworkerRepository
    {
        void AddSadottypeofworker(Sadottypeofworker sadottypeofworker);
        void DeleteSadottypeofworker(Sadottypeofworker sadottypeofworker);
        void UpdateSadottypeofworker(Sadottypeofworker sadottypeofworker);
        List<Sadottypeofworker> GetAllSadottypeofworker();
    }
}
