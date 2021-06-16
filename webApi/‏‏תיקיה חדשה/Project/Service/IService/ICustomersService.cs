using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
   public interface ICustomersService
    {
        void AddCustomer(CCustomers customer);
        void DeleteCustomer(CCustomers custimer);
        void UpdateCustomer(CCustomers custimer);
        List<CCustomers> GetAllCustomer();
        CCustomers Getcustomer(string Id, string name);
    }
}
