using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IWorkersRepository
    {
        void AddWorkers(Workers workers);
        void DeleteWorkers(Workers workers);
        void UpdateWorkers(Workers workers);
        List<Workers> GetAllWorkers();

    }
}
