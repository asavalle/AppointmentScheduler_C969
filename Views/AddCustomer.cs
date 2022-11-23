using AppointmentScheduler_C969.Controllers;
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
            /*
             * This form takes user input data and separately breaks down the information into the separate 
             * objects for database input.
             * Starting with the country information to establish the countryId.
             */
    public partial class AddCustomer : Form
    {

        Customer newCustomer = new Customer();
        Address newCustAddress = new Address();
        

        public AddCustomer()
        {           

            InitializeComponent();

        }

        private void linkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btn_CreateCustomer_Click(object sender, EventArgs e)
        {


            //country
            //newCustCountry.CountryName = tb_newCustCountry.Text;
            //newCustCountry.CreateDate = DateTime.Now;
            //newCustCountry.CreatedBy = DataAccess.LoggedInUser;
            //newCustCountry.LastUpdate = DateTime.Now;
            //newCustCountry.LastUpdateBy = DataAccess.LoggedInUser;
            //CustomersController.CreateCountry(newCustCountry);

            //city
            //newCustCity.CityName = tb_newCustCity.Text;
            //newCustCity.CountryId = Country.CurrentCountryId;
            //newCustCity.CreateDate = DateTime.Now;
            //newCustCity.CreatedBy = DataAccess.LoggedInUser;
            //newCustCity.LastUpdate = DateTime.Now;
            //newCustCity.LastUpdateBy = DataAccess.LoggedInUser;
            //CustomersController.CreateCity(newCustCity);

            //address
            //newCustAddress.PostalCode = Convert.ToInt32(tb_newCustZip.Text);
            //newCustAddress.CityId = newCustCity.CityId;
            //newCustAddress.Phone = tb_newCustPhone.Text;
            //newCustAddress.CreateDate = DateTime.Now;
            //newCustAddress.CreatedBy = DataAccess.LoggedInUser;
            //newCustAddress.LastUpdate = DateTime.Now;
            //newCustAddress.LastUpdateBy = DataAccess.LoggedInUser;
            //CustomersController.CreateAddress(newCustAddress);

            //customer
            //newCustomer.CustomerName = tb_newCustName.Text;
            //newCustomer.Active = cb_newActiveCust.Checked;
            //newCustomer.CreateDate = DateTime.Now;
            //newCustomer.CreatedBy = DataAccess.LoggedInUser;
            //newCustomer.LastUpdate = DateTime.Now;
            //newCustomer.LastUpdateBy = DataAccess.LoggedInUser;
            //newCustomer.AddressId = newCustAddress.AddressId;
            //newCustomer.CityId = newCustCity.CityId;
            //CustomersController.CreateCustomer(newCustomer);

        }

        private void cb_newActiveCust_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_newActiveCust.Checked == false) { cb_newActiveCust.Checked = true; }
            else { cb_newActiveCust.Checked = false; }
        }

        private void btn_addCity_Click(object sender, EventArgs e)
        {
            try
            {                
                AddCity city = new AddCity();                                
                city.ShowDialog();

                
            }
            catch
            {

            }
        }
    }
}
