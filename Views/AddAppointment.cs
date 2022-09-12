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
        
        public AddAppointment()
        {
            InitializeComponent();
            cb_startTime.DataSource = Appointment.StartTimes;
            cb_endTime.DataSource = Appointment.EndTimes;
            cb_customer.DataSource = Customer.CustomerName;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Date.BuildAppointmentDate(dtp_createDate.Value, cb_startTime.SelectedItem.ToString(), cb_endTime.SelectedItem.ToString()); 
            AppointmentsController.CreateNewAppointment(cb_customer.SelectedItem.ToString(), tb_aptTitle.Text,tb_aptDesc.Text,tb_aptLocation.Text,tb_aptContact.Text,tb_aptType.Text,
                                                        tb_aptURL.Text, Date.startTime, Date.endTime,DateTime.Now,DataAccess.LoggedInUser,DateTime.Now,
                                                        DataAccess.LoggedInUser);
            this.Close();
            
        }


        
        

        private void linkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        
    }
}
