using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Homeology.API.Controllers
{
    public class DealStatusController : ApiController
    {
        // GET: api/DealStatus
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DealStatus/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DealStatus
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DealStatus/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DealStatus/5
        public void Delete(int id)
        {
        }
    }
}
