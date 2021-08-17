using Common;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{

    public class TypetouserService : ITypetouserService
    {
        ITypetouserRepository iTypetR;
        ITypeofworkerRepository iTypeotR;

        public TypetouserService(ITypetouserRepository iTypetR, ITypeofworkerRepository iTypeotR)
        {
            this.iTypetR = iTypetR;
            this.iTypeotR = iTypeotR;
        }
        public void AddTypetouser(CTypetouser Typetou)
        {
           
            Typetouser typetouser = new Typetouser()
            {
                Typetouserid = Typetou.Typetouserid,
                Typeid = Typetou.Typeid,
                Userid = Typetou.Userid,
                Precent = Typetou.Precent,
            };

            iTypetR.AddTypetouser(typetouser);
        }

        public void DeleteTypetouser(CTypetouser Typetou)
        {
            CTypetouser ctypetouser = new CTypetouser()
            {
                Typetouserid = Typetou.Typetouserid,
                Typeid = Typetou.Typeid,
                Userid = Typetou.Userid,
                Precent = Typetou.Precent,
            };
            Typetouser typetouser = new Typetouser()
            {
                Typetouserid = Typetou.Typetouserid,
                Typeid = Typetou.Typeid,
                Userid = Typetou.Userid,
                Precent = Typetou.Precent,
            };
            iTypetR.DeleteTypetouser(typetouser);
        }

        public void UpdateTypetouser(List<CTypetouser> value)
        {
            foreach (var item in value)
            {
                var x = new Typetouser();
                x.Typetouserid = item.Typetouserid;
                x.Typeid = item.Typeid;
                x.Userid = item.Userid;
                x.Precent = item.Precent;
                iTypetR.UpdateTypetouser(x);
            }
        }



        public List<CTypetouser> GetAllTypetouser()
        {

            List<CTypetouser> typetouser = (from tmp in iTypetR.GetAllTypetouser()
                                            select new CTypetouser
                                            {
                                                Typetouserid = tmp.Typetouserid,
                                                Typeid = tmp.Typeid,
                                                Userid = tmp.Userid,
                                                Precent = tmp.Precent,

                                            }).ToList();

            return typetouser;
        }
        public void Avg() 
        {
            var result = iTypetR.GetAllTypetouser() 
            .GroupBy(b => b.Typeid)
            .ToDictionary(
            g => g.Key.ToString(),
            g => new
            {
                s = g.Select(b => b.Precent)
               .Sum(),
                c = g.Count()
            });
            var list = iTypeotR.GetAllTypeofworker();
            foreach (var item in result)
            {
                var t = list.Find(a => a.Typeid == int.Parse(item.Key));
                t.Precent = item.Value.s / item.Value.c;
            }
        }

        public List<CTypetouser> Precents(string id)
        {
            var result = iTypetR.GetAllTypetouser().Where(a => a.Userid == id).Select(tmp => new CTypetouser
            {
                Typetouserid = tmp.Typetouserid,
                Typeid = tmp.Typeid,
                Userid = tmp.Userid,
                Precent = tmp.Precent,

            }).ToList();
            return result;
        }
    }

}


