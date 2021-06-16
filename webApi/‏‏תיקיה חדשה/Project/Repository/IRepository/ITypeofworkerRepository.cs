using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface ITypeofworkerRepository
    {
        void AddTypeofworker(Typeofworker typeofworker);
        void DeleteTypeofworker(Typeofworker typeofworker);
        void UpdateTypeofworker(Typeofworker typeofworker);
        List<Typeofworker> GetAllTypeofworker();

    }
}
