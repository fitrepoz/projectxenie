﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Homeology.API.Controllers
{
    public class ErrorController : ApiController
    {
        // GET: api/Error
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Error/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Error
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Error/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Error/5
        public void Delete(int id)
        {
        }
    }
}
