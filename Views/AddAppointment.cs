using AppointmentScheduler_C969.Controllers;
using AppointmentScheduler_C969.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Views
{
    public partial class AddAppointment : Form
    {
        DateTime startTime = new DateTime();
        DateTime endTime = new DateTime();
        public AddAppointment()
        {
            InitializeComponent();
            cb_startTime.DataSource = Appointment.StartTimes;
            cb_endTime.DataSource = Appointment.EndTimes;
            cb_customer.DataSource = Customer.CustomerName;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            BuildAppointmentDate(); 
            AppointmentsController.CreateNewAppointment(cb_customer.SelectedItem.ToString(), tb_aptTitle.Text,tb_aptDesc.Text,tb_aptLocation.Text,tb_aptContact.Text,tb_aptType.Text,
                                                        tb_aptURL.Text, startTime,endTime,DateTime.Now,DataAccess.LoggedInUser,DateTime.Now,
                                                        DataAccess.LoggedInUser);
            this.Close();
            
        }


        public void BuildAppointmentDate()
        {                  
            /*Creates a new DateTime object, assigns it the value from the DateTimePicker control. Then it takes that new object and assigns
             * it to the aptData variable and applies the ToShortDateString method to grab only the date portion. 
             * After that, the Start and End times are retrieved from the appropriate combobox and then appeneded to the aptData to create a complete
             * start and end date/time variable. Lastly, those variables are parsed into new DateTime objects.
             */
            DateTime date = new DateTime();

            date = dtp_createDate.Value;
            var aptData = date.ToShortDateString();
            string startT = cb_startTime.SelectedItem.ToString();
            string endT = cb_endTime.SelectedItem.ToString();
            var startDateTime = aptData +" " + startT.ToString();
            var endDateTime = aptData + " " + endT.ToString();        
            startTime = DateTime.Parse(startDateTime);         
            endTime = DateTime.Parse(endDateTime);              
        }
        

        private void linkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        
    }
}
