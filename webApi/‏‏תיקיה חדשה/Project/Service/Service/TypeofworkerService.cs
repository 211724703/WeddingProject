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

        public TypeofworkerService(ITypeofworkerRepository iTypeofR)//גישה לרפוזיטורי
        {
            this.iTypeofR = iTypeofR;
        }
        public void AddTypeofworker(CTypeofworker Typeo)
        {
            //CBlocks cBlocks = new CBlocks() { IdBlock=block.IdBlock,NameBlocks=block.NameBlocks};
            Typeofworker typeofworker = new Typeofworker()
            {

                Typeid = Typeo.Typeid,//סיסמה
                Nametype = Typeo.Nametype,//שם משתמש
                Precent = Typeo.Precent,
                Misusetotipe = Typeo.Misusetotipe,
                RouterLink = Typeo.RouterLink


            };

            iTypeofR.AddTypeofworker(typeofworker);//זהו , זה ההוספה וככה את עושה גם למחיקה והעדכון אשלח לך דוגמא מפורטת
        }                            //עכשיו נעשה את הקונטרולר


        public void DeleteTypeofworker(CTypeofworker Typeo)
        {
            CTypeofworker ctypeofworker = new CTypeofworker()
            {
                Typeid = Typeo.Typeid,//סיסמה
                Nametype = Typeo.Nametype,//שם משתמש
                Precent = Typeo.Precent,
                Misusetotipe = Typeo.Misusetotipe,
                RouterLink = Typeo.RouterLink


            };
            Typeofworker typeofworker = new Typeofworker()
            {
                Typeid = Typeo.Typeid,//סיסמה
                Nametype = Typeo.Nametype,//שם משתמש
                Precent = Typeo.Precent,
                Misusetotipe = Typeo.Misusetotipe,
                RouterLink = Typeo.RouterLink

            }; iTypeofR.DeleteTypeofworker(typeofworker);
        }

        public void UpdateTypeofworker(CTypeofworker Typeo)
        {
            CTypeofworker ctypeofworker = new CTypeofworker()
            {
                Typeid = Typeo.Typeid,//סיסמה
                Nametype = Typeo.Nametype,//שם משתמש
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



        public List<CTypeofworker> GetAllTypeofworker()//מחזיר רשימה 
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



  



