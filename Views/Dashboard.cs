using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public readonly BindingSource bsAppointments = new BindingSource();

        public Dashboard()
        {
            InitializeComponent();
            lb_user.Text = DataAccess.LoggedInUser + " is logged in.";

            bsAppointments.DataSource = Appointment.GetAppoitments();
            dgv_Appointments.DataSource = bsAppointments;
            dgv_Appointments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Appointments.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Appointments.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Appointments.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Appointments.Columns["start"].DefaultCellStyle.Format = "hh:mm tt";
            dgv_Appointments.Columns["end"].DefaultCellStyle.Format = "hh:mm tt";
            dgv_Appointments.Columns["appointment_Date"].DefaultCellStyle.Format = "MM/dd/yyyy";

           
            CheckForUpcomingAppointments();

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
            
        }
        
       

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            //CheckForUpcomingAppointments();
            
            ReloadAppointments();
            ConvertToLocalTime();
        }
        private void ConvertToLocalTime()
        {
            for (int index = 0; index < dgv_Appointments.Rows.Count; index++)
            {
                foreach (DataGridViewCell cell in dgv_Appointments.Rows[index].Cells)
                {
                    if (cell.Value is DateTime time)
                    {
                        cell.Value = time.ToLocalTime();
                    }
                    else
                    {
                        continue;
                    }
                }

            }
        }

        //TODO: CHECKING FOR UPCOMING APPTS NOT WORKING-NEED TO FIX
        private void CheckForUpcomingAppointments()
        {
            DateTime currentTime = DateTime.Now;
            DateTime aptTime = new DateTime();

            //TODO: Need to determine if appointment date is current date, and if any appointments are withing 15 minutes of current time.

        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DataAccess.loginSuccessful = false;
            this.Close();
        }


        /* 
         * Appointments
         */
        private void dgv_Appointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dgv_Appointments.SelectedRows;
            foreach (DataGridViewRow row in selectedRow)
            {
                Appointment.SelectedAppointmentId = Convert.ToInt32(row.Cells[0].Value.ToString());

            }
        }


        private void btn_AddApt_Click(object sender, EventArgs e)
        {
            AddAppointment newAppointment = new AddAppointment();
            newAppointment.ShowDialog();
        }
        private void btn_DelApt_Click(object sender, EventArgs e)
        {
            if(selectedRow != null)
            {
                AppointmentsController.DeleteAppointment(selectedRow);

            }
            else
            {
                MessageBox.Show("No record selected. Please select a record.");
            }
            ReloadAppointments();
        }
        private void btn_ModAppt_Click(object sender, EventArgs e)
        {
            if(selectedRow != null) { 
                ModifyAppointment modifyApt = new ModifyAppointment();
                modifyApt.ShowDialog();           

            }
            else
            {
                MessageBox.Show("No record selected. Please select a record.");
            }

        }
        public void ReloadAppointments()
        {
            selectedRow = null;
            dgv_Appointments.DataSource = Appointment.GetAppoitments();
            dgv_Appointments.Sort(dgv_Appointments.Columns["appointmentId"], System.ComponentModel.ListSortDirection.Ascending);
        }
        
        //Sort Appointments by current month
        private void btn_showByMonth_Click(object sender, EventArgs e)
        {

            dgv_Appointments.DataSource = Appointment.GetAppointmentsByMonth(); ;

        }

        //Sort Appointments by current week
        private void btn_showByWeek_Click(object sender, EventArgs e)
        {                     
           
            dgv_Appointments.DataSource = Appointment.GetAppointmensByWeek(); 
 
        }
        private void btn_showAll_Click(object sender, EventArgs e)
        {
            dgv_Appointments.DataSource = Appointment.GetAppoitments();

        }


        /*
         * Customers
         */
        
        private void dgv_Customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dgv_Customers.SelectedRows;
            foreach(DataGridViewRow row in selectedRow)
            {
                Customer.SelectedCustomerID = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer newCustomer = new AddCustomer();
            newCustomer.ShowDialog();

        }
    }
}
