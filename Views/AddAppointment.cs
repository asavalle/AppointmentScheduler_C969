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
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Appointment newAppt = new Appointment();

            newAppt.Title = tb_aptTitle.Text;
            newAppt.Description = tb_aptDesc.Text;
            newAppt.Location = tb_aptLocation.Text;
            newAppt.Contact = tb_aptContact.Text;
            newAppt.Type = tb_aptType.Text;
            // TODO: finish building out object....
            
        }
    }
}
