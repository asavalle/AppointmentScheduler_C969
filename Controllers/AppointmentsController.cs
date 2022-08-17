using System;
using System.Collections.Generic;
using System.Text;
using AppointmentScheduler_C969.Views;
using AppointmentScheduler_C969.Models;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Controllers
{
    /*
    * This Class handles communication between the user (AddAppointments.cs view) and the database, 
    * utilizing the data model (Appointment.cs).
    */
    class AppointmentsController
    {

        public static void CreateNewAppointment(string customer,string title, string description, string location, string contact, string type, string url, DateTime start,
                            DateTime end, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            Appointment newAppt = new Appointment();
            newAppt.Customer = customer ;
            newAppt.Title = title;
            newAppt.Description = description;
            newAppt.Location = location;
            newAppt.Contact = contact;
            newAppt.Type = type;
            newAppt.URL = url;
            newAppt.StartTime = start;
            newAppt.EndTime = end;
            newAppt.CreateDate = DateTime.Now;
            newAppt.CreatedBy = DataAccess.loggedInUser;
            newAppt.LastUpdate = DateTime.Now;
            newAppt.LastUpdateBy = DataAccess.loggedInUser;

            //Appointment.InsertRecord();

            MessageBox.Show(
                            newAppt.Title + "\n" +
                            newAppt.Description + "\n" +
                            newAppt.Location + "\n" +
                            newAppt.Contact + "\n" +
                            newAppt.Type + "\n" +
                            newAppt.URL + "\n" +
                            newAppt.StartTime + "\n" +
                            newAppt.EndTime + "\n" +
                            newAppt.CreateDate + "\n" +
                            newAppt.CreatedBy + "\n" +
                            newAppt.LastUpdate + "\n" +
                            newAppt.LastUpdateBy) ;
        }



    }
}
