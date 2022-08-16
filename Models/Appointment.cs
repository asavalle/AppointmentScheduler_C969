using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentScheduler_C969.Models
{
    class Appointment
    {

        public int AppointmentId { get; set; } //autoincrements on the database side
        public string Customer { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string URL { get; set; }
        public static List<string> StartTimes { get; set; } = new List<string>();
        public static List<string> EndTimes { get; set; } = new List<string>();
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
       
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        //new Appointment constructor
        public Appointment() { }
        public Appointment(string customer,string title, string description, string location, string contact, string type, string url, DateTime start, 
                            DateTime end, DateTime createDate,string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this.Customer = customer;
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

        public static void GenerateTimes()
        {
            var culture = new System.Globalization.CultureInfo("en-Us");
            
            for (int i = 5; i <= 17; i++) //from 5am to 5pm
            {
                DateTime date = new DateTime(1, 1, 1, i, 00, 00);
                StartTimes.Add(date.ToShortTimeString());
                EndTimes.Add(date.ToShortTimeString());
            }
            

        }
        public static void InsertRecord()
        {
            //db logic insert
            DataAccess.OpenConnection();
            
        }


    }
}
