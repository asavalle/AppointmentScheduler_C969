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
    public partial class AddCity : Form
    {
        public AddCity()
        {
            InitializeComponent();
            Country.UpdateListOfCountries();
            cb_countryList.DataSource = Country.listOfCountries;
        }



        private void ll_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
