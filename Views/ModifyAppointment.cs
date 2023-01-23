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
            User.FillUserList();
            cb_modCustomer.DataSource = Customer.Names;
            cb_userModApt.DataSource = User.UserNames;

        }

        private void ModifyAppointment_Load(object sender, EventArgs e)
        {
            try
            { 
                //Convert Appointments DataTable to an Enumerable to be able to access fields.
                DataTable aptTable = Appointment.GetAppointments();
                //LAMBDA expresssion used here to get the selected appointment's ID. This method is more efficient than creating a method to retrieve the selected appointment's ID.
                var selectedApt = aptTable.AsEnumerable().Where(x => x.Field<int>("appointmentId") == Appointment.SelectedAppointmentId).FirstOrDefault();
            
            
                //Pass ID to the GetCurrentAppointment method to retreive all the values from the DB.
                Appointment currentApt = Appointment.GetCurrentAppointment(selectedApt.Field<int>("appointmentId"));

               Appointment.GenerateTimes(Convert.ToDateTime(currentApt.StartTime.ToShortDateString()));
                cb_modSTime.DataSource = Appointment.StartTimes;
                cb_modETime.DataSource = Appointment.EndTimes;
                cb_modAptType.DataSource = Appointment.AppointmentTypes;

                //Populate form fields from selected row's data.
                tb_aptID.Text = currentApt.AppointmentId.ToString();
                cb_userModApt.Text = User.GetUserNameById(currentApt.UserId);
                cb_modCustomer.SelectedItem = currentApt.CustomerName;
                tb_modContact.Text = currentApt.Contact;
                tb_modTitle.Text = currentApt.Title;
                cb_modAptType.Text = currentApt.Type;
                tb_modDescription.Text = currentApt.Description;
                dtp_modDate.Value = currentApt.CreateDate;
                cb_modSTime.Text = currentApt.StartTime.ToShortTimeString();
                cb_modETime.Text = currentApt.EndTime.ToShortTimeString();
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
        private void dtp_modDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Appointment.SelectedAppointmentDateCreated = dtp_modDate.Value;
                if (Appointment.SelectedAppointmentDateCreated.DayOfWeek == DayOfWeek.Saturday || Appointment.SelectedAppointmentDateCreated.DayOfWeek == DayOfWeek.Sunday)
                {
                    lb_DayOfWkWarningMod.Visible = true;
                    cb_modSTime.Visible = false;
                    cb_modETime.Visible = false;
                }
                else
                {
                    lb_DayOfWkWarningMod.Visible = false;
                    cb_modSTime.Visible = true;
                    cb_modETime.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Date.BuildAppointmentDate(dtp_modDate.Value, cb_modSTime.SelectedItem.ToString(), cb_modETime.SelectedItem.ToString());

                bool isOverlapping = Appointment.IsModAppointmentOverlapping(Appointment.GetCurrentAppointment(Appointment.SelectedAppointmentId),User.GetUserIDbyName(cb_userModApt.Text), Date.startTime, Date.endTime);


                if (!isOverlapping)
                {

                    tempApptObj.AppointmentId = Appointment.SelectedAppointmentId;
                    tempApptObj.CustomerName = cb_modCustomer.SelectedItem.ToString();
                    tempApptObj.CustomerId = Customer.GetCustomerIdByName(tempApptObj.CustomerName);
                    tempApptObj.UserId = User.GetUserIDbyName(cb_userModApt.Text);
                    tempApptObj.Contact = tb_modContact.Text;
                    tempApptObj.Title = tb_modTitle.Text;
                    tempApptObj.Type = cb_modAptType.Text;
                    tempApptObj.Description = tb_modDescription.Text;
                    tempApptObj.CreateDate = Appointment.SelectedAppointmentDateCreated;
                    tempApptObj.LastUpdate = DateTime.Now;
                    tempApptObj.StartTime = Date.startTime;
                    tempApptObj.EndTime = Date.endTime;
                    tempApptObj.Location = tb_modLocation.Text;
                    tempApptObj.URL = tb_modURL.Text;



                    AppointmentsController.ModifyAppointment(tempApptObj);
                    foreach (Control c in this.gb_modAptForm.Controls)
                    {
                        c.Enabled = false;
                    }


                    Appointment.StartTimes.Clear();
                    Appointment.EndTimes.Clear();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("The selected date of this appointment overlaps with another appointment for the selected Consultant / User)", "Appointment Overlap Warning!");

                }

            }            
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

      

        private void cb_modCustomer_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cb_modCustomer.Text.Length == 0)
            {
                error = "A Customer Name must be selected.";
                e.Cancel = true;
            }
            errPr_ModApts.SetError((Control)sender, error);
        }

        private void tb_modContact_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (tb_modContact.Text.Length == 0)
            {
                error = "A Customer contact must be entered.";
                e.Cancel = true;
            }
            errPr_ModApts.SetError((Control)sender, error);
        }

        private void tb_modTitle_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (tb_modTitle.Text.Length == 0)
            {
                error = "Please enter an appoitnment Title.";
                e.Cancel = true;
            }
            errPr_ModApts.SetError((Control)sender, error);
        }

        private void cb_modAptType_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cb_modAptType.Text.Length == 0)
            {
                error = "An appointment Type must be selected.";
                e.Cancel = true;
            }
            errPr_ModApts.SetError((Control)sender, error);
        }

        private void dtp_modDate_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (dtp_modDate.Value.Date < DateTime.Now.Date || dtp_modDate.Value == null)
            {
                error = "Please use the dropdown to select a date greater than or equal to today's date.";
                e.Cancel = true;
            }
            errPr_ModApts.SetError((Control)sender, error);
        }

        private void cb_modETime_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            var startTime = DateTime.Parse(cb_modSTime.Text);
            var endTime = DateTime.Parse(cb_modETime.Text);

            if (startTime > endTime)
            {
                error = "Start Time cannot be after End Time.";
                e.Cancel = true;
            }
            errPr_ModApts.SetError((Control)sender, error);
        }

        private void cb_modSTime_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cb_modSTime.Text.Length == 0)
            {
                error = "An appoitnment Start Time must be selected.";
                e.Cancel = true;
            }
            errPr_ModApts.SetError((Control)sender, error);
        }

      
    }
}
