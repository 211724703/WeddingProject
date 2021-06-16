using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public  interface IValuestosadeofworkerRepository
    {
        void AddValuestosadeofworker(Valuestosadeofworker valuestosadeofworker);
        void DeleteValuestosadeofworker(Valuestosadeofworker valuestosadeofworker);
        void UpdateValuestosadeofworker(Valuestosadeofworker valuestosadeofworker);
        List<Valuestosadeofworker> GetAllValuestosadeofworker();


    }
}
