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
            
            cb_modCustomer.DataSource = Customer.Names;

        }

        private void ModifyAppointment_Load(object sender, EventArgs e)
        {
            try
            { 
                //Convert Appointments DataTable to an Enumerable to be able to access fields.
                DataTable aptTable = Appointment.GetAppoitments();
                //Get selected appointment's ID
                var selectedApt = aptTable.AsEnumerable().Where(x => x.Field<int>("appointmentId") == Appointment.SelectedAppointmentId).FirstOrDefault();
            
            
                //Pass ID to the GetCurrentAppointment method to retreive all the values from the DB.
                Appointment currentApt = Appointment.GetCurrentAppointment(selectedApt.Field<int>("appointmentId"));

               Appointment.GenerateTimes(Convert.ToDateTime(currentApt.StartTime.ToShortDateString()));
                cb_modSTime.DataSource = Appointment.StartTimes;
                cb_modETime.DataSource = Appointment.EndTimes;

                //Populate form fields from selected row's data.
                tb_aptID.Text = currentApt.AppointmentId.ToString();
                cb_modCustomer.SelectedItem = currentApt.CustomerName;
                tb_modContact.Text = currentApt.Contact;
                tb_modTitle.Text = currentApt.Title;
                tb_modType.Text = currentApt.Title;
                tb_modDescription.Text = currentApt.Description;
                dtp_modDate.Value = currentApt.CreateDate;
                cb_modSTime.SelectedItem = currentApt.StartTime.ToLocalTime().ToShortTimeString();
                cb_modETime.SelectedItem = currentApt.EndTime.ToLocalTime().ToShortTimeString();
                tb_modLocation.Text = currentApt.Location;
                tb_modURL.Text = currentApt.URL;

                tempApptObj = currentApt;
            }
            catch
            {
                MessageBox.Show("A row must be selected.");
                this.Close();
            }
            
        }

        private void btn_editApt_Click(object sender, EventArgs e)
        {
           

            //Set's all the child controls of the form to enabled
            foreach (Control c in this.gb_modAptForm.Controls)
            {
                c.Enabled = true;
            }
           
            btn_Save.Visible = true;

            
        }

        private void linkLabel_modCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Appointment.StartTimes.Clear();
            Appointment.EndTimes.Clear();
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {


                //Date.BuildAppointmentDate(dtp_modDate.Value, cb_modSTime.SelectedItem.ToString(), cb_modETime.SelectedItem.ToString());
                tempApptObj.AppointmentId = Appointment.SelectedAppointmentId;
                tempApptObj.CustomerName = cb_modCustomer.SelectedItem.ToString();
                tempApptObj.CustomerId = Customer.GetCustomerIdByName(tempApptObj.CustomerName);
                tempApptObj.Contact = tb_modContact.Text;
                tempApptObj.Title = tb_modTitle.Text;
                tempApptObj.Type = tb_modType.Text;
                tempApptObj.Description = tb_modDescription.Text;
                tempApptObj.CreateDate = Appointment.SelectedAppointmentDateCreated;
                tempApptObj.LastUpdate = DateTime.Now;
                tempApptObj.StartTime = Convert.ToDateTime(cb_modSTime.SelectedValue);
                tempApptObj.EndTime = Convert.ToDateTime(cb_modETime.SelectedValue);
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


            Appointment.StartTimes.Clear();
            Appointment.EndTimes.Clear();

            this.Close();
        }

        private void cb_modSTime_DropDown(object sender, EventArgs e)
        {
            //cb_modSTime.SelectedItem = "";
            //cb_modETime.SelectedItem = "";

            //Appointment.GenerateTimes(Convert.ToDateTime(tempApptObj.StartTime));
            //cb_modSTime.DataSource = Appointment.StartTimes;
            //cb_modETime.DataSource = Appointment.EndTimes;
        }
    }
}
