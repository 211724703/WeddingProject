using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service;
using Common;
using Repository.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeddingProject.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
   
    {
        ICustomersService iCustS;
        ITypetouserService iUserS;
        public CustomersController(ICustomersService iCustS, ITypetouserService iUserS) 
        {
            this.iCustS = iCustS;
            this.iUserS = iUserS;
            
        }

        // GET: api/<controller>
        [HttpGet]
        public List<CCustomers> Get()
        {

            return iCustS.GetAllCustomer();
        }


        
        // GET api/<controller>/5

        [HttpGet("Getcustomer/{id}/{name}")]

        public CCustomers Getcustomer(string Id, string name)
        {
            return iCustS.Getcustomer(Id, name);
        }

        [HttpGet("Precents/{id}")]

        public List<CTypetouser> Precents(string id)
        {
            return iUserS.Precents(id);
        }



        // GET api/<controller>/5
        [HttpGet("/{id}")]
        public string Get(int id)
        {
            return "";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/<controller>/5
        [HttpPost("UpdateCustomer")]
        public void UpdateCustomer([FromBody] CCustomers custom)
        {
            iCustS.UpdateCustomer(custom);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public void Put([FromBody]CCustomers customer)
        {
            iCustS.AddCustomer(customer);
        }


        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void DeleteC(CCustomers custom)
        {
            iCustS.DeleteCustomer(custom);
        }
    }
}
