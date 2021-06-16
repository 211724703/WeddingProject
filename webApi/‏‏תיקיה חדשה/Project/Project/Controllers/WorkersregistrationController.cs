using Common;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingProject.Controllers
{

    [Route("api/[controller]")]////////////////////////////////////
    public class WorkersregistrationController : ControllerBase
    //שימי לב שזה חייב להסתימם במילה קונטרולר
    {
        IWorkersregistrationServise iWorkersrS;
        public WorkersregistrationController(IWorkersregistrationServise iWorkersrS) //זה הזרקה לסרויס
        {
            this.iWorkersrS = iWorkersrS;
            //פה יכול  להיות לך הרבה הזרקות להרבה סרויסיםץ אל תשכחי להוסיף אותם בפעולה הבונה
        }

        // GET: api/<controller>
        [HttpGet]
        public List<CWorkersregistration> Get()
        {

            return iWorkersrS.GetAllWorkersregistration();
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
        [HttpPut]
        public void Put(int id, [FromBody]CWorkersregistration Worker)
        {
            iWorkersrS.AddWorkersregistration(Worker);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}

