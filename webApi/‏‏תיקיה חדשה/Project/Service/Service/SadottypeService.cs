using Common;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class SadottypeService : ISadottypeService
    {
        ISadottypeRepository iSadotR;

        public SadottypeService(ISadottypeRepository iSadotR)//גישה לרפוזיטורי
        {
            this.iSadotR = iSadotR;
        }
        public void AddSadottype(CSadottype Sad)
        {
            //CBlocks cBlocks = new CBlocks() { IdBlock=block.IdBlock,NameBlocks=block.NameBlocks};
            Sadottype sadottype = new Sadottype()
            {

                Sadetypeid = Sad.Sadetypeid,//סיסמה
                Sadetypeteur = Sad.Sadetypeteur,//שם משתמש

            };

            iSadotR.AddSadottype(sadottype);//זהו , זה ההוספה וככה את עושה גם למחיקה והעדכון אשלח לך דוגמא מפורטת
        }                            //עכשיו נעשה את הקונטרולר


        public void DeleteSadottype(CSadottype Sad)  //מחיקת לקוח
        {
            CSadottype Ssadottype = new CSadottype()
            {

                Sadetypeid = Sad.Sadetypeid,
                Sadetypeteur = Sad.Sadetypeteur,
            };

            Sadottype sadottype = new Sadottype()
            {

                Sadetypeid = Sad.Sadetypeid,
                Sadetypeteur = Sad.Sadetypeteur,
            };
            iSadotR.DeleteSadottype(sadottype);
        }
        public void UpdateSadottype(CSadottype Sad)   
        {
            CSadottype Ssadottype = new CSadottype()
            {

                Sadetypeid = Sad.Sadetypeid,
                Sadetypeteur = Sad.Sadetypeteur,
            };

            Sadottype sadottype = new Sadottype()
            {

                Sadetypeid = Sad.Sadetypeid,
                Sadetypeteur = Sad.Sadetypeteur,
            };
            iSadotR.UpdateSadottype(sadottype);
        }



        public List<CSadottype> GetAllSadottype()//מחזיר רשימה 
        {

            List<CSadottype> sadottype = (from tmp in iSadotR.GetAllSadottype()
                                          select new CSadottype
                                          {
                                              Sadetypeid = tmp.Sadetypeid,
                                              Sadetypeteur = tmp.Sadetypeteur,

                                          }).ToList();

            return sadottype;
        }
  

    }


}

