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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawString(Report., richTextBox1.Font, Brushes.Black, 100, 20);
            //e.Graphics.PageUnit = GraphicsUnit.Inch;
        }

    }
}
