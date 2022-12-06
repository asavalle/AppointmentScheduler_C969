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
            lb_user.Text = DataAccess.LoggedInUser + " is logged in";

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

            dgv_addresses.DataSource = Address.GetAddresses();
            
        }
        
       

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            
            ReloadAppointments();
            ReloadCustomers();
            ReloadAddresses();
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

        private void CheckForUpcomingAppointments()
        {
            DateTime currentTime = DateTime.Now;
            DateTime currentDate = DateTime.Now.Date;
            DateTime aptTime = new DateTime();
            DateTime aptDate = new DateTime();

            foreach(DataRow row in Appointment.GetAppoitments().Rows) 
            {

                aptTime = row.Field<DateTime>("start").ToLocalTime();
                aptDate = aptTime.Date;

                if (aptDate == currentDate) //Determine if appointment date matches current date.
                {
                    if (aptTime >= currentTime && aptTime <= currentTime.AddMinutes(15)) //Determine if the apt time is between current time and current time plus 15 mins.
                    {
                        MessageBox.Show($"Appointment {row.Field<int>("appointmentId")} is upcoming at : " + aptTime.ToLocalTime(),"Alert!" );

                    }
                }

            }
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


        /*************************
         * *******Customers*******
         ************************/
        public void ReloadCustomers()
        {
            dgv_Customers.DataSource = null;
            dgv_Customers.DataSource = Customer.GetCustomers();
            //dgv_Customers.Refresh();
            for (int i = 0; i < dgv_Customers.Columns.Count; i++)
            {
                dgv_Customers.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }
        private void dgv_Customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dgv_Customers.SelectedRows;
            foreach(DataGridViewRow row in selectedRow)
            {
                Customer.SelectedCustomerID = Convert.ToInt32(row.Cells[0].Value);
                Customer.SelectedCustomerAddressId = Address.GetAddressIdFromCustomerId(Customer.SelectedCustomerID);
                Customer.SelectedCustomerCityId = City.GetCityIdFromAddressId(Customer.SelectedCustomerAddressId);
            }
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer newCustomer = new AddCustomer();
            newCustomer.ShowDialog();

        }

        private void btn_ModCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                ModifyCustomer modCust = new ModifyCustomer();
                modCust.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_DelCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                bool appointmentFound = false;

                //verify customer is not associated with an appointment
                foreach (DataGridViewRow row in dgv_Appointments.Rows)
                {
                    if (Customer.GetCustomerIdByName(row.Cells[1].Value.ToString()) == Customer.SelectedCustomerID)
                    {
                        appointmentFound = true;
                        MessageBox.Show($"This customer has an associated appointment, ID {row.Cells[0].Value}, and cannot be deleted. \n" +
                            $"Please delete associated appointment before proceeding.");
                    }                    

                }
                if (!appointmentFound)
                {
                    var custNameToDelete = Customer.GetCustomerNameById(Customer.SelectedCustomerID);

                    DialogResult confirmDelete = MessageBox.Show($"Do you want to delete customer {custNameToDelete}?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirmDelete == DialogResult.Yes)
                    {
                        Customer.DeleteCustomerRecord(Customer.SelectedCustomerID);
                        MessageBox.Show($"{custNameToDelete} has been deleted.");

                    }
                    DialogResult deleteAddress = MessageBox.Show($"Would you like to delete {custNameToDelete}'s address from the system?", "Delete Address?", MessageBoxButtons.YesNo);
                    if(deleteAddress == DialogResult.Yes)
                    {
                        Address.DeleteCustomerAddress(Customer.SelectedCustomerAddressId);
                    }
                }

            }
            catch
            {
                
            }
        }





        /*************************
         * *******Addresses*******
         ************************/
        public void ReloadAddresses()
        {
            dgv_addresses.DataSource = null;
            dgv_addresses.DataSource = Address.GetAddresses();
            //dgv_addresses.Refresh();
            for (int i = 0; i < dgv_addresses.Columns.Count; i++)
            {
                dgv_addresses.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btn_delAddress_Click(object sender, EventArgs e)
        {
            try
            {
                bool addressFound = false;

                //verify customer is not associated with an appointment
                foreach (DataGridViewRow row in dgv_Customers.Rows)
                {
                    if (Convert.ToInt32(row.Cells[2].Value) == Address.SelectedAddressID)
                    {
                        addressFound = true;
                        MessageBox.Show($"This address has customer record {row.Cells[0].Value} associated with it and cannot be deleted. Delete the customer record before proceeding.");
                    }

                }
                if (!addressFound)
                {
                    var addressToDelete = Address.SelectedAddressID;

                    DialogResult confirmDelete = MessageBox.Show($"Do you want to delete address?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirmDelete == DialogResult.Yes)
                    {
                        Address.DeleteCustomerAddress(Address.SelectedAddressID);

                        MessageBox.Show($"Address deleted");

                    }

                }

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgv_addresses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dgv_addresses.SelectedRows;
            foreach (DataGridViewRow row in selectedRow)
            {
                Address.SelectedAddressID = Convert.ToInt32(row.Cells[0].Value);

            }
        }
    }

}
