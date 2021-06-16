using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
   public interface IStatusServicecs
    {
        void AddStatus(CStatus Stat);
        void DeleteStatus(CStatus Stat);
        void UpdateStatus(CStatus Stat);
        List<CStatus> GetAllStatus();
    }
}
