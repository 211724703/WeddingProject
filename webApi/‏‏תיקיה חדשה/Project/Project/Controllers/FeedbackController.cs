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
    public class FeedbackController: ControllerBase
    {

            IFeedbackServise iFeedbackS;
            
            public FeedbackController(IFeedbackServise iFeedbackS)
            {
                this.iFeedbackS = iFeedbackS;
            }

            // GET: api/<controller>
            [HttpGet]
            public List<CFeedback> Get()
            {
                return iFeedbackS.GetAllFeedback();
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
