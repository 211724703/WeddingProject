using Common;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
  public  interface IWorkersServise
    {
        void AddWorkers(CWorkers Work);
        void DeleteWorkers(CWorkers Work);
        void UpdateWorkers(CWorkers Work);
        List<CWorkers> GetAllWorkers();
        List<CWorkers> Getworker(int Id);
        //List<CWorkers> Getworkes(List<Valuestosadeofworker> Listvalues);
        void Getworkes();
        object[] GetDetailsWorkerByType(int Id);
        object GetDetailsWorkerById(int Id);
        object[] GetinformWorker(int tId, int wId);
        CWorkers GetworkerByName(string name);
    }
}
