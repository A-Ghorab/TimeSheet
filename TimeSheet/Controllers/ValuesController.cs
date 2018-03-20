using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.Repositories;

namespace TimeSheet.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private ProjectTimelineHistoryRepository projectTimelineHistoryRepository;
        public ValuesController(ProjectTimelineHistoryRepository projectTimelineHistoryRepository)
        {
            this.projectTimelineHistoryRepository = projectTimelineHistoryRepository;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public String Post([FromBody]string value)
        {
            return value;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public String Put(int id, [FromBody]string value)
        {
            return "Post Hit";
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
