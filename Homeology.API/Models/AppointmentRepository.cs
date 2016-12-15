using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homeology.API.Models
{
    public class AppointmentRepository
    {
        private static HomeologyEntities homeologyContext = new HomeologyEntities();
        public static List<Appointment> GetAllAppointments()
        {
            var query = from appointment in homeologyContext.Appointments
                        select appointment;
            return query.ToList();
        }

        public static List<Appointment> SearchAppointmentsByName(string appointmentName)
        {
            var query = from appointment in homeologyContext.Appointments
                        where appointment.title.Contains(appointmentName)
                        select appointment;
            return query.ToList();
        }

        public static List<Appointment> SearchAppointmentsByAgent(int agentId)
        {
            var query = from appointment in homeologyContext.Appointments
                        where appointment.agent_id.Equals(agentId)
                        select appointment;
            return query.ToList();
        }

        public static List<Appointment> SearchAppointmentsByDeal(int dealId)
        {
            var query = from appointment in homeologyContext.Appointments
                        where appointment.deal_id.Equals(dealId)
                        select appointment;
            return query.ToList();
        }

        public static Appointment GetAppointment(int appointmentId)
        {
            var query = from appointment in homeologyContext.Appointments
                        where appointment.appointment_id == appointmentId
                        select appointment;
            return query.SingleOrDefault();
        }

        public static Appointment GetAppointment(string appointmentName)
        {
            var query = from appointment in homeologyContext.Appointments
                        where appointment.title == appointmentName
                        select appointment;
            return query.SingleOrDefault();
        }

        public static List<Appointment> InsertAppointment(Appointment e)
        {
            homeologyContext.Appointments.Add(e);
            homeologyContext.SaveChanges();
            return GetAllAppointments();
        }

        public static List<Appointment> UpdateAppointment(Appointment e)
        {
            var data = (from appointment in homeologyContext.Appointments
                       where appointment.appointment_id == e.appointment_id
                       select appointment).SingleOrDefault();
            data.title = e.title;
            data.agenda = e.agenda;
            data.location = e.location;
            data.agent_rsvp = e.agent_rsvp;
            data.client_rsvp = e.client_rsvp;
            data.start_time = e.start_time;
            data.end_time = e.end_time;
            homeologyContext.SaveChanges();
            return GetAllAppointments();
        }

        public static List<Appointment> DeleteAppointment(int appointmentId)
        {
            var data = (from appointment in homeologyContext.Appointments
                       where appointment.appointment_id == appointmentId
                        select appointment).SingleOrDefault();
            homeologyContext.Appointments.Remove(data);
            homeologyContext.SaveChanges();
            return GetAllAppointments();
        }

        public void Dispose()
        {
            homeologyContext.Dispose();
        }

    }
}