using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
   public interface IWorkertoweddingServise
    {
        void AddWorkertowedding(CWorkertowedding Workert);
        void DeleteWorkertowedding(CWorkertowedding Workert);
        void UpdateWorkertowedding(CWorkertowedding Workert);
        List<CWorkertowedding> GetAllWorkertowedding();
    }
}
