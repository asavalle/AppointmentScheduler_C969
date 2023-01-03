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
    public partial class ConsultantReport : Form
    {
        public ConsultantReport()
        {
            InitializeComponent();


        }

        private void ConsultantReport_Load(object sender, EventArgs e)
        {
            tb_UserSchedule.Text = Report.ViewUserSchedule();

        }
    }
}
