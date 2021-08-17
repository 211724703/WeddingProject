using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service;
using Common;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeddingProject.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    
    {
        ICustomersService iCustS;
        public CustomersController(ICustomersService iCustS)ס
        {
            this.iCustS = iCustS;
         
        }

        // GET: api/<controller>
        [HttpGet]
        public List<CCustomers> Get()
        {

            return iCustS.GetAllCustomer();  
        }


        
        // GET api/<controller>/5

        [HttpGet("Getcustomer/{id}/{name}")]

        public CCustomers Get(string Id, string name)
        {
            return iCustS.Getcustomer(Id, name);
        }

        

        // GET api/<controller>/5
        [HttpGet("/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
            
        }

        // PUT api/<controller>/5
        [HttpPut("UpdateCustomer {custom}")]
        public void PutUpdateCustomer(CCustomers custom)
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
