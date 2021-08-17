using Repository.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;

namespace Repository
{
   public class CustomersRepository: ICustomersRepository
    {
        DB context;
        public CustomersRepository(DB context)
        {
            this.context = context;
        }
   

        public void AddCustomer(Customers customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public void DeleteCustomer(Customers custimer)
        {
            context.Customers.Remove(custimer);
            context.SaveChanges();
        }

        public void UpdateCustomer(Customers custimer)
        {
            context.Customers.Update(custimer);
            context.SaveChanges();
        }


        public List<Customers> GetAllCustomer()
        {

            return context.Customers.ToList();
        }

        

       


    }
}
