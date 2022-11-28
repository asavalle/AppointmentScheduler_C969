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

        private void btn_addCountry_Click(object sender, EventArgs e)
        {
            //Country newCountry = new Country();

            //newCountry.CountryId = null;
            //newCountry.CountryName = 


            //Country.InsertCountryRecord(newCountry);
        }

        private void btn_addCity_Click(object sender, EventArgs e)
        {
            City newCity = new City();

            newCity.CityName = tb_cityName.Text;
            newCity.CountryId = Country.GetCountryIdFromName(cb_countryList.SelectedItem.ToString());
            newCity.CreateDate = DateTime.Now;
            newCity.CreatedBy = DataAccess.LoggedInUser;
            newCity.LastUpdate = DateTime.Now;
            newCity.LastUpdateBy = DataAccess.LoggedInUser;

            City.InsertCityRecord(newCity);
        }
    }
}
