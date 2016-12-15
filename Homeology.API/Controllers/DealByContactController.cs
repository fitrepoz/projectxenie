using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Homeology.API.Controllers
{
    public class DealByContactController : ApiController
    {
        // GET: api/DealByContact
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DealByContact/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DealByContact
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DealByContact/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DealByContact/5
        public void Delete(int id)
        {
        }
    }
}
