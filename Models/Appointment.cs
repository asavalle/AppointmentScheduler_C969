﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentScheduler_C969.Models
{
    class Appointment
    {

        public int AppointmentId { get; set; } //autoincrements on the database side
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string URL { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        //new Appointment constructor
        public Appointment() { }
        public Appointment(string title, string description, string location, string contact, string type, string url, DateTime start, 
                            DateTime end, DateTime createDate,string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this.Title = title;
            this.Description = description;
            this.Location = location;
            this.Contact = contact;
            this.Type = type;
            this.URL = url;
            this.StartTime = start;
            this.EndTime = end;
            this.CreateDate = createDate;
            this.CreatedBy = createdBy;
            this.LastUpdate = lastUpdate;
            this.LastUpdateBy = lastUpdateBy;
        }


    }
}
