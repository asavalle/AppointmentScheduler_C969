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

        public static void CreateNewAppointment(string customerName, string title, string description, string location, string contact, string type, string url, DateTime start,
                            DateTime end, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            

            Appointment newAppt = new Appointment();
            newAppt.CustomerId = Customer.GetCustomerId(customerName);
            newAppt.CustomerName = customerName;
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

            Appointment.InsertAppointment(newAppt);

            MessageBox.Show(
                            "Customer ID " + newAppt.CustomerId + "\n Customer: " +
                            newAppt.CustomerName + "\n Title: " +
                            newAppt.Title + "\n Description: " +
                            newAppt.Description + " \n Location: " +
                            newAppt.Location + " \n Contact: " +
                            newAppt.Contact + "\n Type: " +
                            newAppt.Type + "\n URL: " +
                            newAppt.URL + "\n StartTime: " +
                            newAppt.StartTime + "\n EndTime: " +
                            newAppt.EndTime + "\n CreateDate: " +
                            newAppt.CreateDate + "\n CreatedBy: " +
                            newAppt.CreatedBy + "\n LastUpdate: " +
                            newAppt.LastUpdate + "\n LastUpdatedBy:     " +
                            newAppt.LastUpdateBy, "Appointment Created") ;           
        }

        public static void DeleteAppointment(DataGridViewSelectedRowCollection row)
        {

            int appointmentIDValue =-1;
            
            foreach(DataGridViewRow r in row)
            {
                appointmentIDValue = Convert.ToInt32(r.Cells[0].Value);
                //MessageBox.Show(r.Cells[0].Value.ToString()) ;
            }
            Appointment.DeleteAppointment(appointmentIDValue);

          
        }

        public static void ModifyAppointment()
        {
            //Take in data passed from Appointment class and construct it into usable object to pass to view.

            Appointment.ModifyAppointment();

        }
    }
}
