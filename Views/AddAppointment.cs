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
            Appointment.GenerateTimes();
            cb_startTime.DataSource = Appointment.StartTimes;
            cb_endTime.DataSource = Appointment.EndTimes;
            cb_customer.DataSource = GetCustomerList();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            BuildAppointmentDate();
            AppointmentsController.CreateNewAppointment(cb_customer.Text, tb_aptTitle.Text,tb_aptDesc.Text,tb_aptLocation.Text,tb_aptContact.Text,tb_aptType.Text,
                                                        tb_aptURL.Text, startTime,endTime,DateTime.Now,DataAccess.loggedInUser,DateTime.Now,
                                                        DataAccess.loggedInUser);
            

        }


        public void BuildAppointmentDate()
        {
           
            
            DateTime date = new DateTime();

            date = dtp_createDate.Value;
            var aptData = date.ToShortDateString();
            string startT = cb_startTime.SelectedItem.ToString();
            string endT = cb_endTime.SelectedItem.ToString();

            var startDateTime = aptData +" " + startT.ToString();
            var endDateTime = aptData + " " + endT.ToString();

            startTime = DateTime.Parse(startDateTime); //use for query
            endTime = DateTime.Parse(endDateTime); //use for query

            
            MessageBox.Show("Start Date/Time " + startDateTime + "\n End Date/Time " + endDateTime);


        }
        public List<string> GetCustomerList()
        {
            DataTable dt = new DataTable();
            dt = DataAccess.GetCustomers();
            List<string> customers = new List<string>();
            foreach(DataRow row in dt.Rows) {
                customers.Add(row.ItemArray.ToString());
            }
            return customers;
        }
    }
}
