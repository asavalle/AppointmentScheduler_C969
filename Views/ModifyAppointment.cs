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
        Appointment tempApptObj = new Appointment();
        

        public ModifyAppointment()
        {
            InitializeComponent();
                                  
            cb_modSTime.DataSource = Appointment.StartTimes;
            cb_modETime.DataSource = Appointment.EndTimes;
            cb_modCustomer.DataSource = Customer.CustomerName;

        }

        private void ModifyAppointment_Load(object sender, EventArgs e)
        {
            
            //Convert Appointments DataTable to an Enumerable to be able to access fields.
            DataTable aptTable = Appointment.GetAppoitments();
            //Get selected appointment's ID
            var selectedApt = aptTable.AsEnumerable().Where(x => x.Field<int>("appointmentId") == Appointment.selectedAppointmentId).FirstOrDefault();
            //Pass ID to the GetCurrentAppointment method to retreive all the values from the DB.
            Appointment currentApt = Appointment.GetCurrentAppointment(selectedApt.Field<int>("appointmentId"));

     
            try
            {
                //Populate form fields from selected row's data.
                tb_aptID.Text = currentApt.AppointmentId.ToString();
                cb_modCustomer.SelectedItem = currentApt.CustomerName;
                tb_modContact.Text = currentApt.Contact;
                tb_modTitle.Text = currentApt.Title;
                tb_modType.Text = currentApt.Title;
                tb_modDescription.Text = currentApt.Description;
                dtp_modDate.Value = currentApt.CreateDate;
                cb_modSTime.Text = currentApt.StartTime.ToShortTimeString();
                cb_modETime.Text = currentApt.EndTime.ToShortTimeString();
                tb_modLocation.Text = currentApt.Location;
                tb_modURL.Text = currentApt.URL;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_editApt_Click(object sender, EventArgs e)
        {
            var currentStartTime = cb_modSTime.Text;
            var currentEndTime = cb_modETime.Text;

            //Set's all the child controls of the form to enabled
            foreach(Control c in this.gb_modAptForm.Controls)
            {
                c.Enabled = true;
            }            

            cb_modSTime.SelectedItem = currentStartTime;
            cb_modETime.SelectedItem = currentEndTime;
            btn_Save.Visible = true;
    
        }

        private void linkLabel_modCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Date.BuildAppointmentDate(dtp_modDate.Value, cb_modSTime.SelectedItem.ToString(), cb_modETime.SelectedItem.ToString());
                tempApptObj.AppointmentId = Appointment.selectedAppointmentId;
                tempApptObj.CustomerName = cb_modCustomer.SelectedItem.ToString();
                tempApptObj.CustomerId = Customer.GetCustomerId(tempApptObj.CustomerName);
                tempApptObj.Contact = tb_modContact.Text;
                tempApptObj.Title = tb_modTitle.Text;
                tempApptObj.Type = tb_modType.Text;
                tempApptObj.Description = tb_modDescription.Text;
                tempApptObj.CreateDate = Appointment.selectedAppointmentDateCreated;
                tempApptObj.LastUpdate = DateTime.Now;
                tempApptObj.StartTime = Date.startTime;
                tempApptObj.EndTime = Date.endTime;
                tempApptObj.Location = tb_modLocation.Text;
                tempApptObj.URL = tb_modURL.Text;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }


            AppointmentsController.ModifyAppointment(tempApptObj);
            foreach (Control c in this.gb_modAptForm.Controls)
            {
                c.Enabled = false;
            }
            this.Close();
        }

        
    }
}
