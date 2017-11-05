using System.Collections.Generic;
using System.Web.Http;

namespace GrepoApi.Controllers
{
    [ServiceRequestActionFilter]
    [RoutePrefix("Values")]
    public class ValuesController : ApiController
    {
        // GET api/value

        [HttpGet]

        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5 
        [HttpGet]

        [Route("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    }
}
