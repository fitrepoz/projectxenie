using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Homeology.API.Models;

namespace Homeology.API.Controllers
{
    [EnableCors(origins: "http://localhost:51351", headers: "*", methods: "*")]
    public class AgentsController : ApiController
    {
        // GET: api/agents
        [Route("api/agents")]
        public HttpResponseMessage Get()
        {
            var agents = AgentsRepository.GetAllAgents();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, agents);
            return response; 
        }

        // GET: api/Agents/5
        [Route("api/agents/{id?}")]
        public HttpResponseMessage Get(int id)
        {
            var agents = AgentsRepository.GetAgent(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, agents);
            return response;
        }

        [Route("api/agents/{name:alpha}")]
        public HttpResponseMessage Get(string name)
        {
            var agents = AgentsRepository.SearchAgentsByName(name);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, agents);
            return response;
        }

        [Route("api/agents")]
        public HttpResponseMessage Post(Agent e)
        {
            var agents = AgentsRepository.InsertAgent(e);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, agents);
            return response;
        }

        [Route("api/agents")]
        public HttpResponseMessage Put(Agent e)
        {
            var agents = AgentsRepository.UpdateAgent(e);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, agents);
            return response;
        }

        [Route("api/agents")]
        public HttpResponseMessage Delete(Agent e)
        {
            var agents = AgentsRepository.DeleteAgent(e);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, agents);
            return response;
        }
    }
}
