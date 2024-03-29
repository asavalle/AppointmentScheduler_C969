﻿using AppointmentScheduler_C969.Controllers;
using AppointmentScheduler_C969.Models;
using System;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Views
{
    public partial class AddCity : Form
    {
        public AddCity()
        {
            InitializeComponent();


        }
        private void AddCity_Load(object sender, EventArgs e)
        {
            Country.UpdateListOfCountries();
            cb_countryList.DataSource = Country.listOfCountries;
        }

        private void ll_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btn_addCountry_Click(object sender, EventArgs e)
        {
            lb_addNewCntry.Visible = true;
            tb_addNewCntry.Visible = true;
            btn_createNewCntry.Visible = true;
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

            CustomersController.CreateCity(newCity);
            City.dtCities.Clear();
            City.UpdateListOfCities();


            MessageBox.Show("New City added.");

            this.Close();
        }

        private void btn_createNewCntry_Click(object sender, EventArgs e)
        {
            Country newCountry = new Country(tb_addNewCntry.Text, DateTime.Now, DataAccess.LoggedInUser, DateTime.Now, DataAccess.LoggedInUser);
            Country.InsertCountryRecord(newCountry);
            Country.UpdateListOfCountries();
            cb_countryList.DataSource = null;
            cb_countryList.DataSource = Country.listOfCountries;

            lb_addNewCntry.Visible = false;
            tb_addNewCntry.Visible = false;
            btn_createNewCntry.Visible = false;

            MessageBox.Show("New Country added.");

        }


    }
}
