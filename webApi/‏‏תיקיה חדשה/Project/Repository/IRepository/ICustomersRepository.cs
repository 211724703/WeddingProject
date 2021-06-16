using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Repository
{
  public  interface  ICustomersRepository
    {
        void AddCustomer(Customers customer);
        void DeleteCustomer(Customers custimer);
        void UpdateCustomer(Customers appsAndWebsites);
        List<Customers> GetAllCustomer();
    }
}
