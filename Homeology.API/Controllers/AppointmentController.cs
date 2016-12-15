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
    public class AppointmentController : ApiController
    {
        // GET: api/appointments
        [Route("api/appointments")]
        public IEnumerable<Appointment> Get()
        {
            return AppointmentRepository.GetAllAppointments();
        }

        // GET api/appointments/5
        [Route("api/appointments/{id?}")]
        public Appointment Get(int id)
        {
            return AppointmentRepository.GetAppointment(id);
        }

        // GET api/appointments/5
        [Route("api/appointments/agent/{id?}")]
        public List<Appointment> SearchByAgentId(int agentId)
        {
            return AppointmentRepository.SearchAppointmentsByAgent(agentId);
        }

        // GET api/appointments/5
        [Route("api/appointments/deal/{id?}")]
        public IEnumerable<Appointment> SearchByDealId(int dealId)
        {
            return AppointmentRepository.SearchAppointmentsByDeal(dealId);
        }

        [Route("api/appointments/{name:alpha}")]
        public Appointment Get(string name)
        {
            return AppointmentRepository.GetAppointment(name);
        }

        [Route("api/appointments/{name:alpha}")]
        public IEnumerable<Appointment> SearchByAppointmentName(string name)
        {
            return AppointmentRepository.SearchAppointmentsByName(name);
        }

        [Route("api/appointments")]
        public IEnumerable<Appointment> Post(Appointment app)
        {
            return AppointmentRepository.InsertAppointment(app);
        }

        [Route("api/appointments/{id}")]
        public IEnumerable<Appointment> Put([FromBody]Appointment app)
        {
            return AppointmentRepository.UpdateAppointment(app);
        }

        [Route("api/appointments/{id}")]
        [HttpDelete]
        public IEnumerable<Appointment> Delete(int id)
        {
            return AppointmentRepository.DeleteAppointment(id);
        }
    }
}
