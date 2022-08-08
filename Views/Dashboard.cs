using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Views
{
    public partial class Dashboard : Form
    {
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
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer newCustomer = new AddCustomer();
            newCustomer.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {        
            this.Close();
        }

        private void btn_AddApt_Click(object sender, EventArgs e)
        {
            AddAppointment newAppointment = new AddAppointment();
            newAppointment.Show();
        }
    }
}
