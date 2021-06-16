using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IStatusRepository
    {
        void AddStatus(Status status);
        void DeleteStatus(Status status);
        void UpdateStatus(Status status);
        List<Status> GetAllStatus();

    }
}
