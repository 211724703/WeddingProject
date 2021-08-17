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

        public CustomerService(ICustomersRepository iCustR)
        {
            this.iCustR = iCustR;
        }

        public void AddCustomer(CCustomers custom)
        {
            //CBlocks cBlocks = new CBlocks() { IdBlock=block.IdBlock,NameBlocks=block.NameBlocks};
            Customers customers = new Customers()
            {

                UserId = custom.UserId,
                Username = custom.Username,
                Namchatan = custom.Namchatan,
                NameCala = custom.NameCala,
                DateWedding = custom.DateWedding,
                Taktziv = custom.Taktziv,
                MailChatan = custom.MailChatan,
                MailCala = custom.MailCala,
                Misinvited = custom.Misinvited,



            };

            iCustR.AddCustomer(customers);
        }                     


        public void DeleteCustomer(CCustomers custom)  
        {
            CCustomers ccustomers = new CCustomers()
            {
                UserId = custom.UserId,
                Username = custom.Username,
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
                UserId = custom.UserId,
                Username = custom.Username,
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

        public void UpdateCustomer(CCustomers custom)    
        {
            CCustomers ccustomers = new CCustomers()
            {
                UserId = custom.UserId,
                Username = custom.Username,
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
                UserId = custom.UserId,
                Username = custom.Username,
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





        public List<CCustomers> GetAllCustomer() 
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



    }
}


