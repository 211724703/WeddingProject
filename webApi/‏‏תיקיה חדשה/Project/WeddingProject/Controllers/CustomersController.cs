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
    //שימי לב שזה חייב להסתימם במילה קונטרולר
    {
        ICustomersService iCustS;
        ITypetouserService iUserS;
        public CustomersController(ICustomersService iCustS, ITypetouserService iUserS) //זה הזרקה לסרויס
        {
            this.iCustS = iCustS;
            this.iUserS = iUserS;
            //פה יכול  להיות לך הרבה הזרקות להרבה סרויסים אל תשכחי להוסיף אותם בפעולה הבונה
        }

        // GET: api/<controller>
        [HttpGet]
        public List<CCustomers> Get()
        {

            return iCustS.GetAllCustomer();
        }


        //זימון הפונקציה שליפת משתמש ע"יי הכנסת שם משתמש וסיסמא
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
