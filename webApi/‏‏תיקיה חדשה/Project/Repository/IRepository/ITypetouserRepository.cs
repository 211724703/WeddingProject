using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface ITypetouserRepository
    { 
        void AddTypetouser(Typetouser typetouser);
        void DeleteTypetouser(Typetouser typetouser);
        void UpdateTypetouser(Typetouser typetouser);
        List<Typetouser> GetAllTypetouser();
    }
}
