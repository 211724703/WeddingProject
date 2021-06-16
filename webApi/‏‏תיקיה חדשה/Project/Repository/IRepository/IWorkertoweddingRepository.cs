using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
   public interface IWorkertoweddingRepository
    {
        void AddWorkertowedding(Workertowedding workertowedding);
        void DeleteWorkertowedding(Workertowedding workertowedding);
        void UpdateWorkertowedding(Workertowedding workertowedding);
        List<Workertowedding> GetAllWorkertowedding();
    }
}
