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


        public Dashboard()
        {
            InitializeComponent();
            lb_user.Text = DataAccess.loggedInUser + " is logged in.";

            dgv_Appointments.DataSource = DataAccess.GetAppoitments();
            dgv_Customers.DataSource = DataAccess.GetCustomers();
            dgv_Customers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Customers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Customers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Customers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Users.DataSource = DataAccess.GetUsers();
            dgv_Users.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Users.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Users.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Users.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataAccess.CloseConnection();
        }
        private void Dashboard_Activated(object sender, EventArgs e)
        {
            ReloadAppointments();
        }
        public void ReloadAppointments()
        {
            dgv_Appointments.DataSource = DataAccess.GetAppoitments();
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

            //TODO: Get selected row of data
            

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
            //MessageBox.Show("The current Appointment ID is " + Appointment.selectedAppointmentId );
        }
    }
}
