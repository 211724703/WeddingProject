using Common;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
   public interface ITypetouserService
    {
        void AddTypetouser(CTypetouser Typetou);
        void DeleteTypetouser(CTypetouser Typetou);
        void UpdateTypetouser(List<CTypetouser> value);
        List<CTypetouser> GetAllTypetouser();
        List<CTypetouser> Precents(string id);
        void Avg();
    }
}
