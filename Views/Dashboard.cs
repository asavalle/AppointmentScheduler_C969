using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AppointmentScheduler_C969.Controllers;
using AppointmentScheduler_C969.Models;

namespace AppointmentScheduler_C969.Views
{
    public partial class Dashboard : Form
    {
        public static DataGridViewSelectedRowCollection selectedRow;
        Appointment tempApt = new Appointment();
        private BindingSource bsAppointments = new BindingSource();

        public Dashboard()
        {
            InitializeComponent();
            lb_user.Text = DataAccess.LoggedInUser + " is logged in.";

            bsAppointments.DataSource = Appointment.GetAppoitments();
            dgv_Appointments.DataSource = bsAppointments;
            dgv_Appointments.Sort(dgv_Appointments.Columns["appointmentId"], ListSortDirection.Ascending);
            dgv_Appointments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Appointments.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Appointments.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Appointments.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Appointments.Columns["start"].DefaultCellStyle.Format = "hh:mm tt";
            dgv_Appointments.Columns["end"].DefaultCellStyle.Format = "hh:mm tt";
            dgv_Appointments.Columns["appointment_Date"].DefaultCellStyle.Format = "MM/dd/yyyy";


            dgv_Customers.DataSource = Customer.GetCustomers();
            dgv_Users.DataSource = User.GetUsers();
            dgv_Customers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Customers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Customers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Customers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_Users.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Users.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Users.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Users.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataAccess.CloseConnection();

            Customer.GetCustomerList();
            Appointment.GenerateTimes();
        }
        private void Dashboard_Activated(object sender, EventArgs e)
        {
            ReloadAppointments();
        }
        public void ReloadAppointments()
        {
            dgv_Appointments.DataSource = Appointment.GetAppoitments();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Appointments*/
        private void btn_AddApt_Click(object sender, EventArgs e)
        {
            AddAppointment newAppointment = new AddAppointment();
            newAppointment.Show();
        }
        private void btn_DelApt_Click(object sender, EventArgs e)
        {
            selectedRow = dgv_Appointments.SelectedRows;
            AppointmentsController.DeleteAppointment(selectedRow);
            ReloadAppointments();
        }
        private void btn_ModAppt_Click(object sender, EventArgs e)
        {
            ModifyAppointment modifyApt = new ModifyAppointment();
            modifyApt.Show();           

        }

        /*Customers*/
        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer newCustomer = new AddCustomer();
            newCustomer.Show();
        }

        private void dgv_Appointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = dgv_Appointments.SelectedRows;
            foreach(DataGridViewRow row in selectedRow)
            {
                Appointment.selectedAppointmentId = Convert.ToInt32(row.Cells[0].Value.ToString());

            }
        }
    }
}
