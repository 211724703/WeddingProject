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
    public class WorkersController : ControllerBase
    
    {
        IWorkersServise iWorkerS;
        public WorkersController(IWorkersServise iWorkerS) 
        {
            this.iWorkerS = iWorkerS;
            
        }

        // GET: api/<controller>
        [HttpGet]
        public List<CWorkers> Get()
        {

            return iWorkerS.GetAllWorkers();
        }
        
        
        // GET api/<controller>/5
        [HttpGet("Getworker/{id}")]
        public List<CWorkers>  Get(int id)
        {
            return iWorkerS.Getworker(id);
        }

       

        

        [HttpGet("GetworkerByName/{name}")]
        public CWorkers GetByName(string name)
        {
            return iWorkerS.GetworkerByName(name);
        }


        [HttpGet("GetDetailsWorkerByType/{id}")]
        public object[] GetDetailsWorkerByType(int id)
        {
            return iWorkerS.GetDetailsWorkerByType(id);   
        }

        [HttpGet("GetDetailsWorkerById/{id}")]
        public object GetDetailsWorkerById(int id)
        {
            return iWorkerS.GetDetailsWorkerById(id);
        }

         

        [HttpGet("GetinformWorker/{id1}/{id2}")]
        public object[] Getinform(int tid,int wId)
        {
            return iWorkerS.GetinformWorker(tid, wId);
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
