//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homeology.API
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        public int ID { get; set; }
        public int appointment_id { get; set; }
        public Nullable<int> deal_id { get; set; }
        public Nullable<int> agent_id { get; set; }
        public string title { get; set; }
        public string agenda { get; set; }
        public string location { get; set; }
        public Nullable<bool> agent_rsvp { get; set; }
        public Nullable<bool> client_rsvp { get; set; }
        public Nullable<System.DateTime> start_time { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
    
        public virtual Deal Deal { get; set; }
    }
}
