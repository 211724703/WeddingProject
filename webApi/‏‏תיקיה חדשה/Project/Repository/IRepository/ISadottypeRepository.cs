using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
   public interface ISadottypeRepository
    {
        void AddSadottype(Sadottype sadottype);
        void DeleteSadottype(Sadottype sadottype);
        void UpdateSadottype(Sadottype sadottype);
        List<Sadottype> GetAllSadottype();

    }
}
