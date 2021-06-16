using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
   public interface IValuestosadeofworkerService
    { 
        void AddValuestosadeofworker(CValuestosadeofworker valuesto);
        void DeleteValuestosadeofworker(CValuestosadeofworker valuesto);
        void UpdateValuestosadeofworker(CValuestosadeofworker valuesto);

        List<CValuestosadeofworker> GetAllValuestosadeofworker();
    }
}
