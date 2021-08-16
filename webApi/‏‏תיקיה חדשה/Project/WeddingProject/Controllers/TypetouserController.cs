using Common;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingProject.Controllers
{

    [Route("api/[controller]")]
    public class TypetouserController : ControllerBase
    {

        ITypetouserService iTypetoS;
        
        public TypetouserController(ITypetouserService iTypetoS) 
        {
            this.iTypetoS = iTypetoS;
            
        }

        // GET: api/<controller>
        [HttpGet]
        public List<CTypetouser> Get()
        {

            return iTypetoS.GetAllTypetouser();
        }


        

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public CTypetouser Get(string id)
        {
            return iTypetoS.GetAllTypetouser().FirstOrDefault(x => x.Userid == id);
        }

        [HttpGet("Precents/{id}")]
        public List<CTypetouser> Precents(string id)
        {
            return iTypetoS.Precents(id);
        }


        // POST api/<controller>
        [HttpPost("saveTypeToUser")]
        public void saveTypeToUser([FromBody] List<CTypetouser> value)
        {            
            iTypetoS.UpdateTypetouser(value);
            iTypetoS.Avg();
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

