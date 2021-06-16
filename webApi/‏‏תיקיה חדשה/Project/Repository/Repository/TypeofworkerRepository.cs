using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    class TypeofworkerRepository:ITypeofworkerRepository
    {
        DB context;
        public TypeofworkerRepository(DB context)//ההזרקה של לדטה בייס
        {
            this.context = context;
        }


        public void AddTypeofworker(Typeofworker typeofworker)
        {
            context.Typeofworker.Add(typeofworker);
            context.SaveChanges();
        }

        public void DeleteTypeofworker(Typeofworker typeofworker)
        {
            context.Typeofworker.Update(typeofworker);
            context.SaveChanges();
        }

        public void UpdateTypeofworker(Typeofworker typeofworker)
        {
            context.Typeofworker.Remove(typeofworker);
            context.SaveChanges();
        }


        public List<Typeofworker> GetAllTypeofworker()
        {

            return context.Typeofworker.ToList();

        }


        //////שליפת שם משתמש וסיסמה
        //public Customers getcustomer(int Id, string name)
        //{

        //    {
        //        Customers result = context.Customers.First(a => a.Username == name && a.UserId == Id);
        //        return result;
        //    }
        //}

        //  1.	פונקציה שמחזירה  מפתח וערך(מוזיקה ,30 אחוז) מה הלקוח רצה וכמה אחוזים...ואם לא לוקחים מהטבלה

        //        public void Percentchange(string nametypeofworker,int Precent)//קיבלנו בעל מקצוע וכמה אחוזים 
        //        {

        //        }
        //             [Nametype] NVARCHAR(50) NOT NULL,

        //[Precent]      INT
    }
}
