using Common;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    class SelectionQueryServise
    {
        //IStatusServicecs iStS;
        IWorkersServise iwork;
        ISadottypeofworkerService isad;


        public SelectionQueryServise(IWorkersServise iwork, ISadottypeofworkerService isad)
        {
            this.iwork = iwork;
            this.isad = isad;

        }


        //  1.הצגת סוגי בעלי המקצוע למשתמש והוא בוחר מה הוא רוצה
        //2.באנגולר בודקים מהה בחרנו


        //   בחירת סוג בעלי מקצוע
        //sum= כל האחוזים שנבחרו
        //        //    100-sum =למה שנותר לחלק
        //       =ההוספה  50/100*30

        //אם עוברים את ה100




        ////מחזיר רשימת ערכים עפ"י קוד שדה
        //public void  Enter(int Id)
        //{
        //    List<CValuestosadeofworker> result = GetAllValuestosadeofworker().Where(a => a.Sadeid == Id).ToList();
        //    return result;
        //}





        //public List<CWorkers> Filter()
        //{
        //    iwork.Getworker( Id);
        //    iwork.Getworkes();

        // }


        ////ICustomersRepository iCustR;

        //public CustomerService(ICustomersRepository iCustR)//גישה לרפוזיטורי
        //{
        //    this.iCustR = iCustR;
        //}



        //////שליפת שם משתמש וסיסמה
        //public static DbSet<Customers> getcustomer(int Id, string name)
        //{
        //    using (Database1Entities db = new Database1Entities())
        //    {
        //        var result = db.Customers;/*.First()(a => a.Username == name && a.UserId == Id)*/
        //        return result;
        //    }
        //}
        //public CCustomers getCustomer(int Id, string name)
        //{
        //    var result = 
        //}



        //public List<CCompany> GetAllComp()  // פןנקציה שמחזירה את רשימת החברות שיש להם טיסות
        //{
        //    List<CCompany> companies = (from c in companyRepository.GetCompanies()
        //                                select new CCompany { Id = c.Id, Description = c.Description }).ToList(); ;
        //    return companies;
        //}


        //public List<CFlight> GetAllF()  //מחזיר את כל הטיסות
        //{
        //    List<Flight> flights = flightRepository.GetAllFlight();
        //    List<CFlight> cFlights = new List<CFlight>();
        //    foreach (var item in flights)
        //    {
        //        cFlights.Add(new CFlight { Id = item.Id, Company = item.Company, From = item.From, To = item.To });
        //    }

        //    return cFlights;

        //}

    }
}
