using Common;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;        
using System.Text;

namespace Service
{
    public class CustomerService : ICustomersService
    {
        ICustomersRepository iCustR;

        public CustomerService(ICustomersRepository iCustR)//גישה לרפוזיטורי
        {
            this.iCustR = iCustR;
        }

        public void AddCustomer(CCustomers custom)
        {
            //CBlocks cBlocks = new CBlocks() { IdBlock=block.IdBlock,NameBlocks=block.NameBlocks};
            Customers customers = new Customers()
            {

                UserId = custom.UserId,//סיסמה
                Username = custom.Username,//שם משתמש
                Namchatan = custom.Namchatan,
                NameCala = custom.NameCala,
                DateWedding = custom.DateWedding,
                Taktziv = custom.Taktziv,
                MailChatan = custom.MailChatan,
                MailCala = custom.MailCala,
                Misinvited = custom.Misinvited,



            };

            iCustR.AddCustomer(customers);//זהו , זה ההוספה וככה את עושה גם למחיקה והעדכון אשלח לך דוגמא מפורטת
        }                            //עכשיו נעשה את הקונטרולר


        public void DeleteCustomer(CCustomers custom)  //מחיקת לקוח
        {
            CCustomers ccustomers = new CCustomers()
            {
                UserId = custom.UserId,//סיסמה
                Username = custom.Username,//שם משתמש
                Namchatan = custom.Namchatan,
                NameCala = custom.NameCala,
                DateWedding = custom.DateWedding,
                Taktziv = custom.Taktziv,
                MailChatan = custom.MailChatan,
                MailCala = custom.MailCala,
                Misinvited = custom.Misinvited,
            };
            Customers customers = new Customers()
            {
                UserId = custom.UserId,//סיסמה
                Username = custom.Username,//שם משתמש
                Namchatan = custom.Namchatan,
                NameCala = custom.NameCala,
                DateWedding = custom.DateWedding,
                Taktziv = custom.Taktziv,
                MailChatan = custom.MailChatan,
                MailCala = custom.MailCala,
                Misinvited = custom.Misinvited,
            };
            iCustR.DeleteCustomer(customers);
        }

        public void UpdateCustomer(CCustomers custom)    // עידכון לקוח
        {
            CCustomers ccustomers = new CCustomers()
            {
                UserId = custom.UserId,//סיסמה
                Username = custom.Username,//שם משתמש
                Namchatan = custom.Namchatan,
                NameCala = custom.NameCala,
                DateWedding = custom.DateWedding,
                Taktziv = custom.Taktziv,
                MailChatan = custom.MailChatan,
                MailCala = custom.MailCala,
                Misinvited = custom.Misinvited,
            };
            Customers customers = new Customers()
            {
                UserId = custom.UserId,//סיסמה
                Username = custom.Username,//שם משתמש
                Namchatan = custom.Namchatan,
                NameCala = custom.NameCala,
                DateWedding = custom.DateWedding,
                Taktziv = custom.Taktziv,
                MailChatan = custom.MailChatan,
                MailCala = custom.MailCala,
                Misinvited = custom.Misinvited,
            };
            iCustR.UpdateCustomer(customers);
        }





        public List<CCustomers> GetAllCustomer()//מחזיר רשימה 
        {
            List<CCustomers> customers = (from tmp in iCustR.GetAllCustomer()
                                          select new CCustomers
                                          {
                                              UserId = tmp.UserId,//סיסמה
                                              Username = tmp.Username,//שם משתמש
                                              Namchatan = tmp.Namchatan,
                                              NameCala = tmp.NameCala,
                                              DateWedding = tmp.DateWedding,
                                              Taktziv = tmp.Taktziv,
                                              MailChatan = tmp.MailChatan,
                                              MailCala = tmp.MailCala,
                                              Misinvited = tmp.Misinvited,

                                          }).ToList();

            return customers;
        }

        ////שליפת שם משתמש וסיסמה
        public CCustomers Getcustomer(string Id, string name)
        {                //CCustomers customers = GetAllCustomer().FirstOrDefault(a => a.UserId == Id && a.Username == name);

            {
                List<CCustomers> list = GetAllCustomer();
                CCustomers customerDeails = list.Find(a => a.UserId.Equals( Id));
                if (customerDeails == null)
                    return null;
                if(customerDeails.Username.Equals(name))
                    return customerDeails;
                return null ;
            }
        }

     //CCustomers customers = GetAllCustomer().FirstOrDefault(a => a.UserId == Id && a.Username == name);

        ////שליפת שם משתמש וסיסמה
        //public static DbSet<Customers> getcustomer(int Id, string name)
        //{
        //    using (Database1Entities db = new Database1Entities())
        //    {
        //        var result = db.Customers;/*.First()(a => a.Username == name && a.UserId == Id)*/
        //        return result;
        //    }
        //}


        ////שליפת שם משתמש וסיסמה
        //public Customers Getcustomer(int Id, string name)//מכני
        //{

        //    {
        //        CCustomers result = (from tmp in iCustR.getcustomer(a => a.Username == name && a.UserId == Id)
        //                             select new CCustomers
        //                             {
        //                                 UserId = tmp.UserId,//סיסמה
        //                                 Username = tmp.Username,//שם משתמש
        //                                 Namchatan = tmp.Namchatan,
        //                                 NameCala = tmp.NameCala,
        //                                 DateWedding = tmp.DateWedding,
        //                                 Taktziv = tmp.Taktziv,
        //                                 MailChatan = tmp.MailChatan,
        //                                 MailCala = tmp.MailCala,
        //                                 Misinvited = tmp.Misinvited,
        //                             });

        //        return result;
        //    }
        //}



        ////שליפת שם משתמש וסיסמה
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
        //    CCustomers result = from c in CustomersRepository.
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


