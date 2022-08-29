using AppointmentScheduler_C969.Controllers;
using AppointmentScheduler_C969.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Views
{
    public partial class ModifyAppointment : Form
    {
        public ModifyAppointment()
        {
            InitializeComponent();
            DataTable aptTable = DataAccess.GetAppoitments();
            var selectedApt = aptTable.AsEnumerable().Where(x => x.Field<int>("appointmentId") == Appointment.selectedAppointmentId).FirstOrDefault();
            
            //set the Customer Name list
            Customer.GetCustomerList();
            Appointment.GenerateTimes();

            cb_modCustomer.DataSource = Customer.CustomerName;
            


            //set the Customer name to the selected name of the appointment
            cb_modCustomer.SelectedItem = Customer.GetCustomerName(selectedApt.Field<int>("customerId"));
            tb_modContact.Text = selectedApt.Field<string>("contact");
            tb_modTitle.Text = selectedApt.Field<string>("title");
            tb_modType.Text = selectedApt.Field<string>("type");
            tb_modDescription.Text = selectedApt.Field<string>("description");
            dtp_modDate.Value = selectedApt.Field<DateTime>("start");
            cb_modSTime.Text = selectedApt.Field<DateTime>("start").ToShortTimeString();
            cb_modETime.Text = selectedApt.Field<DateTime>("end").ToShortTimeString();
            tb_modLocation.Text = selectedApt.Field<string>("location");
            tb_modURL.Text = selectedApt.Field<string>("url");
            

        }

        private void btn_editApt_Click(object sender, EventArgs e)
        {
            //Set's all the child controls of the form to enabled
            foreach(Control c in this.gb_modAptForm.Controls)
            {
                c.Enabled = true;
            }
            cb_modSTime.DataSource = Appointment.StartTimes;
            cb_modETime.DataSource = Appointment.EndTimes;
            btn_Save.Visible = true;


            AppointmentsController.ModifyAppointment();
        }

        private void linkLabel_modCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
