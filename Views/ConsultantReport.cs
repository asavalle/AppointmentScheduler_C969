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
            User.FillUserList();

        }

        private void ConsultantReport_Load(object sender, EventArgs e)
        {

            cb_reportUsrSelect.DataSource = User.UserNames;
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            tb_UserSchedule.Text = Report.ViewUserSchedule();

        }

        private void btn_usrReportDisplay_Click(object sender, EventArgs e)
        {
            tb_UserSchedule.Text = Report.ViewUserSchedule(cb_reportUsrSelect.Text);
        }

        private void btn_clearReport_Click(object sender, EventArgs e)
        {
            tb_UserSchedule.Clear();
        }
    }
}
