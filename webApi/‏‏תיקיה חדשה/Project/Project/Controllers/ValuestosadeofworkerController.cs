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
    public class ValuestosadeofworkerController : ControllerBase
    {

        IValuestosadeofworkerService IValues;
        public ValuestosadeofworkerController(IValuestosadeofworkerService IValues) 
        {
            this.IValues = IValues;
            
        }

        // GET: api/<controller>
        [HttpGet]
        public List<CValuestosadeofworker> Get()
        {

            return IValues.GetAllValuestosadeofworker();
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

