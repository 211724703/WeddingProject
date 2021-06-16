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
        List<CWorkers> Getworker(int Id);////שליפת בעל מקצוע לפי סוג
        //List<CWorkers> Getworkes(List<Valuestosadeofworker> Listvalues);//מקבל רשימה של ערכים
        void Getworkes();
        object[] GetDetailsWorkerByType(int Id);//החזרת פרטי בעל מיקצוע + מחיר
        object GetDetailsWorkerById(int Id);
        object[] GetinformWorker(int tId, int wId);//החזרת פרטי בעל מיקצוע + מחיר למידע נוסף
        CWorkers GetworkerByName(string name);//שליפת בעל מיקצוע עפ"י שם
    }
}
