using Common;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingProject.Controllers 
{
    [Route("api/[controller]")]
    public class TypeofworkerController : ControllerBase
    {

        ITypeofworkerService iTypeofS;
        public TypeofworkerController(ITypeofworkerService iTypeofS) //זה הזרקה לסרויס
        {
            this.iTypeofS = iTypeofS;
            //פה יכול  להיות לך הרבה הזרקות להרבה סרויסיםץ אל תשכחי להוסיף אותם בפעולה הבונה
        }

        // GET: api/<controller>
        [HttpGet]
        public List<CTypeofworker> Get()
        {

            return iTypeofS.GetAllTypeofworker();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
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
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
