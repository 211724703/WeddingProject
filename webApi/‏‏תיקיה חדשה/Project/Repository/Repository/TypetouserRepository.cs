using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    class TypetouserRepository:ITypetouserRepository
    {
        DB context;
        public TypetouserRepository(DB context)
        {
            this.context = context;
        }


        public void AddTypetouser(Typetouser typetouser)
        {
            context.Typetouser.Add(typetouser);
            context.SaveChanges();
        }

        public void DeleteTypetouser(Typetouser typetouser)
        {
            context.Typetouser.Remove(typetouser);
            context.SaveChanges();
        }

        public void UpdateTypetouser(Typetouser typetouser)
        {
            var x = context.Typetouser.FirstOrDefault(a => a.Typeid == typetouser.Typeid && a.Userid == typetouser.Userid);
            if (x == null)
            {
                var i = context.Typetouser.Max(a => a.Typetouserid);
                typetouser.Typetouserid = i + 1;
                context.Typetouser.Add(typetouser);
            }
            else
            {
                x.Precent = typetouser.Precent;
                //context.Typetouser.Update(typetouser);
            }
            context.SaveChanges();
        }


        public List<Typetouser> GetAllTypetouser()
        {

            return context.Typetouser.ToList();
        }

    }
}
