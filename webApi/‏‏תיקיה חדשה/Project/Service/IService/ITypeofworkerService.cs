using System;
using System.Collections.Generic;
using System.Text;
using Common;
using Repository.Models;

namespace Service
{
    public interface ITypeofworkerService
    {
        void AddTypeofworker(CTypeofworker Typeo);
        void DeleteTypeofworker(CTypeofworker Typeo);
        void UpdateTypeofworker(CTypeofworker Typeo);
        List<CTypeofworker> GetAllTypeofworker();
        int[] GetPrecentToType(/*List<int> tipe*//*,*/ int scom);//
    }
}
