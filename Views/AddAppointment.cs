﻿using AppointmentScheduler_C969.Controllers;
using AppointmentScheduler_C969.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Views
{
    public partial class AddAppointment : Form
    {

        public AddAppointment()
        {
            InitializeComponent();
            Customer.GetCustomerList();
            User.FillUserList();
            cb_startTime.Visible = false;
            cb_endTime.Visible = false;
            lb_startTime.Visible = false;
            lb_endTime.Visible = false;
            cb_customer.DataSource = Customer.Names;
            cb_userAddApt.DataSource = User.UserNames;
            cb_aptType.DataSource = Appointment.AppointmentTypes;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in gb_addAptForm.Controls)
                {
                    // Set focus on control
                    control.Focus();
                    // Validate causes the control's Validating event to be fired,
                    // if CausesValidation is True
                    if (!Validate())
                    {
                        DialogResult = DialogResult.None;
                        return;
                    }
                }
                if (cb_startTime.SelectedValue != null && cb_endTime.SelectedValue != null)
                {
                    Date.BuildAppointmentDate(dtp_createDate.Value, cb_startTime.SelectedItem.ToString(), cb_endTime.SelectedItem.ToString());
                    bool isOverlapping = Appointment.IsAppointmentOverlapping(User.GetUserIDbyName(cb_userAddApt.Text), Date.startTime, Date.endTime);

                    if (!isOverlapping)
                    {
                        AppointmentsController.CreateNewAppointment(
                            cb_customer.SelectedItem.ToString(),
                            User.GetUserIDbyName(cb_userAddApt.Text),
                            tb_aptTitle.Text, tb_aptDesc.Text,
                            tb_aptLocation.Text, tb_aptContact.Text,
                            cb_aptType.Text,
                            tb_aptURL.Text,
                            Date.startTime,
                            Date.endTime,
                            DateTime.Now,
                            DataAccess.LoggedInUser,
                            DateTime.Now,
                            DataAccess.LoggedInUser);

                        this.Close();
                        Appointment.StartTimes.Clear();
                        Appointment.EndTimes.Clear();
                        cb_customer.DataBindings.Clear();
                        cb_userAddApt.DataBindings.Clear();

                    }
                    else
                    {
                        MessageBox.Show("The selected date of this appointment overlaps with another appointment for the selected Doctor)", "Appointment Overlap Warning!");
                    }



                }
                else
                {
                    MessageBox.Show("The Date was not properly selected for the appointment.");
                }



            }
            catch (System.NullReferenceException nullEx)
            {
                MessageBox.Show(nullEx.Message);
            }

        }





        private void linkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            cb_customer.DataBindings.Clear();

        }

        private void dtp_createDate_ValueChanged(object sender, EventArgs e)
        {
            var date = Convert.ToDateTime(dtp_createDate.Value.ToShortDateString());

            Appointment.GenerateTimes(date);
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                lb_DayOfWkWarning.Visible = true;
            }
            else
            {
                lb_DayOfWkWarning.Visible = false;

                cb_startTime.DataSource = Appointment.StartTimes;
                cb_endTime.DataSource = Appointment.EndTimes;
                lb_startTime.Visible = true;
                lb_endTime.Visible = true;
                cb_startTime.Visible = true;
                cb_endTime.Visible = true;
            }


        }

        //Validating methods
        private void cb_customer_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cb_customer.Text.Length == 0 || cb_customer.Text == " ")
            {
                error = "Please enter a name";
                e.Cancel = true;
            }
            errPr_appts.SetError((Control)sender, error);
        }
        private void cb_userAddApt_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cb_userAddApt.Text.Length == 0 || cb_userAddApt.Text == " ")
            {
                error = "Please select a Doctor";
                e.Cancel = true;
            }
            errPr_appts.SetError((Control)sender, error);
        }
        private void tb_aptContact_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (tb_aptContact.Text.Length == 0 || tb_aptContact.Text == " ")
            {
                error = "Please enter contact information.";
                e.Cancel = true;
            }
            errPr_appts.SetError((Control)sender, error);
        }

        private void tb_aptTitle_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (tb_aptTitle.Text.Length == 0 || tb_aptTitle.Text == " ")
            {
                error = "Please enter a appointment Title.";
                e.Cancel = true;
            }
            errPr_appts.SetError((Control)sender, error);
        }

        private void cb_aptType_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cb_aptType.Text.Length == 0 || cb_aptType.Text == " ")
            {
                error = "Please select an appointment Type.";
                e.Cancel = true;
            }
            errPr_appts.SetError((Control)sender, error);
        }

        private void dtp_createDate_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (dtp_createDate.Value.Date < DateTime.Now.Date)
            {
                error = "Please use the dropdown to select a date greater than or equal to today's date.";
                e.Cancel = true;
            }
            errPr_appts.SetError((Control)sender, error);
        }

        private void cb_endTime_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cb_endTime.Text != " ")
            {
                var startTime = DateTime.Parse(cb_startTime.Text);
                var endTime = DateTime.Parse(cb_endTime.Text);

                if (startTime > endTime)
                {
                    error = "Start Time cannot be after End Time.";
                    e.Cancel = true;
                }

                errPr_appts.SetError((Control)sender, error);

            }
            else
            {
                error = "Start Time cannot be after End Time.";
                e.Cancel = true;
                errPr_appts.SetError((Control)sender, error);

            }
        }
        private void cb_startTime_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cb_startTime.Text.Length == 0 || cb_startTime.Text == " ")
            {
                error = "An appoitnment Start Time must be selected.";
                e.Cancel = true;
            }
            errPr_appts.SetError((Control)sender, error);
        }


    }
}
