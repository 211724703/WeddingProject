using Common;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class TypeofworkerService : ITypeofworkerService
    {
        ITypeofworkerRepository iTypeofR;

        public TypeofworkerService(ITypeofworkerRepository iTypeofR)
        {
            this.iTypeofR = iTypeofR;
        }
        public void AddTypeofworker(CTypeofworker Typeo)
        {
      
            Typeofworker typeofworker = new Typeofworker()
            {

                Typeid = Typeo.Typeid
                Nametype = Typeo.Nametype,
                Precent = Typeo.Precent,
                Misusetotipe = Typeo.Misusetotipe,
                RouterLink = Typeo.RouterLink


            };

            iTypeofR.AddTypeofworker(typeofworker);
        }                            

        public void DeleteTypeofworker(CTypeofworker Typeo)
        {
            CTypeofworker ctypeofworker = new CTypeofworker()
            {
                Typeid = Typeo.Typeid,
                Nametype = Typeo.Nametype,
                Precent = Typeo.Precent,
                Misusetotipe = Typeo.Misusetotipe,
                RouterLink = Typeo.RouterLink


            };
            Typeofworker typeofworker = new Typeofworker()
            {
                Typeid = Typeo.Typeid,
                Nametype = Typeo.Nametype,
                Precent = Typeo.Precent,
                Misusetotipe = Typeo.Misusetotipe,
                RouterLink = Typeo.RouterLink

            }; iTypeofR.DeleteTypeofworker(typeofworker);
        }

        public void UpdateTypeofworker(CTypeofworker Typeo)
        {
            CTypeofworker ctypeofworker = new CTypeofworker()
            {
                Typeid = Typeo.Typeid,
                Nametype = Typeo.Nametype,
                Precent = Typeo.Precent,
                Misusetotipe = Typeo.Misusetotipe,
                RouterLink = Typeo.RouterLink
            };
            Typeofworker typeofworker = new Typeofworker()
            {
                Typeid = Typeo.Typeid,
                Nametype = Typeo.Nametype,
                Precent = Typeo.Precent,
                Misusetotipe = Typeo.Misusetotipe,
                RouterLink = Typeo.RouterLink
            };
            iTypeofR.UpdateTypeofworker(typeofworker);

        }



        public List<CTypeofworker> GetAllTypeofworker()/ 
        {

            List<CTypeofworker> typeofworker = (from tmp in iTypeofR.GetAllTypeofworker()
                                                select new CTypeofworker
                                                {
                                                    Typeid = tmp.Typeid,
                                                    Nametype = tmp.Nametype,
                                                    Precent = tmp.Precent,
                                                    Misusetotipe = tmp.Misusetotipe,
                                                    RouterLink = tmp.RouterLink
                                                }).ToList();

            return typeofworker;
        }

        public int[] GetPrecentToType(int scom)
        {
            throw new NotImplementedException();
        }


    }
}



  



