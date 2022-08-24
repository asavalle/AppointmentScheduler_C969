using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Models
{
    class Appointment
    {

        public int AppointmentId { get; } //autoincrements on the database side
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
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
        public Appointment(int customerId, string customerName, string title, string description, string location, string contact, string type, string url, DateTime start, 
                            DateTime end, DateTime createDate,string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
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
        public static void InsertAppointment(Appointment apt)
        {
            int userId = User.GetUserId();
            var formatSDate = apt.StartTime.ToString("yyyy-MM-dd hh:mm:ss");
            var formatEDate = apt.EndTime.ToString("yyyy-MM-dd hh:mm:ss");
            var formatCreateDate = apt.CreateDate.ToString("yyyy-MM-dd hh:mm:ss");
            var formatLastUpDate = apt.LastUpdate.ToString("yyyy-MM-dd hh:mm:ss");

            if (!DataAccess.isConnOpen)
            {
                DataAccess.OpenConnection();               
            }            
                var insert_cmd = new MySqlCommand($"INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES({apt.CustomerId},{userId},'{apt.Title}','{apt.Description}','{apt.Location}','{apt.Contact}','{apt.Type}','{apt.URL}','{formatSDate}','{formatEDate}','{formatCreateDate}','{apt.CreatedBy}','{formatLastUpDate}','{apt.LastUpdateBy}')", DataAccess.conn);
                var insert = insert_cmd.ExecuteNonQuery();                    
        }

        public static void DeleteAppointment(int aptId)
        {
            if (!DataAccess.isConnOpen)
            {
                DataAccess.OpenConnection();
            }
            if (aptId >= 0)
            {
                try
                {
                    var del_cmd = new MySqlCommand($"DELETE FROM client_schedule.appointment WHERE appointmentId = {aptId};",DataAccess.conn);
                    var delete = del_cmd.ExecuteNonQuery();
                    MessageBox.Show($"Appointment {aptId} was deleted.");

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }



            }
            else
            {
                MessageBox.Show("No record was selected.");
            }
        }

    }
}
