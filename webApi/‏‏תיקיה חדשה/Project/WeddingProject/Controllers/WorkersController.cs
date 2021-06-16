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
    public class WorkersController : ControllerBase///////////
    //שימי לב שזה חייב להסתימם במילה קונטרולר
    {
        IWorkersServise iWorkerS;
        public WorkersController(IWorkersServise iWorkerS) //זה הזרקה לסרויס
        {
            this.iWorkerS = iWorkerS;
            //פה יכול  להיות לך הרבה הזרקות להרבה סרויסיםץ אל תשכחי להוסיף אותם בפעולה הבונה
        }

        // GET: api/<controller>
        [HttpGet]
        public List<CWorkers> Get()
        {

            return iWorkerS.GetAllWorkers();
        }
        
        //החזרת בעלי מקצוע לפי סוג שירות מסוים
        // GET api/<controller>/5
        [HttpGet("Getworker/{id}")]
        public List<CWorkers>  Get(int id)
        {
            return iWorkerS.Getworker(id);
        }

       

        //החזרת בעלי מקצוע  עפ"י שם

        [HttpGet("GetworkerByName/{name}")]
        public CWorkers GetByName(string name)
        {
            return iWorkerS.GetworkerByName(name);
        }

        //החזרת פירטי בעלי מקצוע +מחיר 

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

        // לינפורמציה החזרת פירטי בעלי מקצוע +מחיר 

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
