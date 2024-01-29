using AppointmentScheduler_C969.Models;
using System;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Views
{
    public partial class AppointmentsByMonthType : Form
    {
        public AppointmentsByMonthType()
        {
            InitializeComponent();

            cb_aptTypes.DataSource = Appointment.AppointmentTypes;
            cb_months.DataSource = new BindingSource(Appointment.Months, null);
            cb_months.DisplayMember = "Value";
            cb_months.ValueMember = "Key";
            cb_months.SelectedValue = 01;
        }

        private void btn_displayReport_Click(object sender, EventArgs e)
        {
            var month = cb_months.SelectedValue;
            var type = cb_aptTypes.Text;

            tb_aptsByMonthType.Text = Report.AppointmentTypesByMonth((int)month, type);
        }

        private void btn_clearReport_Click(object sender, EventArgs e)
        {
            tb_aptsByMonthType.Clear();
        }
    }
}
