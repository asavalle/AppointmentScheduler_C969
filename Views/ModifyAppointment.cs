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
            var selectedApt = aptTable.AsEnumerable().Where(x => x.Field<int>("appointmentId") == Appointment.selectedAppointmentId).FirstOrDefault();
            try
            {
                //Populate form fields from selected row's data.
                tb_aptID.Text = selectedApt.Field<int>("appointmentId").ToString();
                cb_modCustomer.SelectedItem = selectedApt.Field<string>("customerName");
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
            var newStart = DateTime.Parse(cb_modSTime.Text);
            var newEnd = DateTime.Parse(cb_modETime.Text);

            tempApptObj.AppointmentId = Appointment.selectedAppointmentId;
            tempApptObj.CustomerName = cb_modCustomer.SelectedItem.ToString();
            tempApptObj.CustomerId = Customer.GetCustomerId(tempApptObj.CustomerName);
            tempApptObj.Contact = tb_modContact.Text;
            tempApptObj.Title = tb_modTitle.Text;
            tempApptObj.Type = tb_modType.Text;
            tempApptObj.Description = tb_modDescription.Text;
            tempApptObj.CreateDate = dtp_modDate.Value;
            tempApptObj.LastUpdate = DateTime.Now;
            tempApptObj.StartTime = newStart;
            tempApptObj.EndTime = newEnd;
            tempApptObj.Location = tb_modLocation.Text;
            tempApptObj.URL = tb_modURL.Text;


            AppointmentsController.ModifyAppointment(tempApptObj);
            foreach (Control c in this.gb_modAptForm.Controls)
            {
                c.Enabled = false;
            }
            this.Close();
        }

        
    }
}
