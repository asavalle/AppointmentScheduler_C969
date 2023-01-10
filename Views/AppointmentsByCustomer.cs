using AppointmentScheduler_C969.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Views
{
    public partial class AppointmentsByCustomer : Form
    {
        public AppointmentsByCustomer()
        {
            InitializeComponent();
            cb_custName.DataSource = Customer.Names;

        }

        private void btn_DisplayByCity_Click(object sender, EventArgs e)
        {
            tb_aptsByCustomer.Text = Report.ViewAppointmentsByCustomer(cb_custName.Text);
        }

        private void btn_clearReport_Click(object sender, EventArgs e)
        {
            tb_aptsByCustomer.Clear();
        }
    }
}
