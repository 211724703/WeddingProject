using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service;
using Common;

namespace WeddingProject.Controllers
{
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {

        IFeedbackServise iFeedbackS;

        public FeedbackController(IFeedbackServise iFeedbackS)
        {
            this.iFeedbackS = iFeedbackS;
        }

        // GET: api/<controller>
        //        [HttpGet]
        //         public List<CFeedback> GetAllFeedback();

        //        {
        //           return iFeedbackS.
        //}

        //GET api/<controller>/5
        [HttpGet("GetAllFeedback/{id}")]
        public List<CFeedback> Get(int id)
        {
            return iFeedbackS.GetAllFeedback().Where(x => x.Workerid == id).ToList();
        }

        // POST api/<controller>
        [HttpPost("AddFeedback")]
        public void AddFeedback([FromBody]CFeedback value)
        {
            iFeedbackS.AddFeedback(value);
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
