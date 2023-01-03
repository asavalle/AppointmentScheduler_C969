using AppointmentScheduler_C969.Controllers;
using AppointmentScheduler_C969.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
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
            City.UpdateListOfCities();
            BindingSource allCities = new BindingSource();

            allCities.DataSource = City.dtCities;
            cb_citiesList.DataSource = City.dtCities;
            cb_citiesList.DisplayMember = "city";
            cb_citiesList.ValueMember = "city";
            

        }

        private void linkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btn_CreateCustomer_Click(object sender, EventArgs e)
        {
            int activeStatus;
            if (cb_newActiveCust.Checked)
            {
                activeStatus = 1;

            }
            else
            {
                activeStatus = 0;
            }

            try
            {
                var selectedCityId = City.GetCityIdFromName(cb_citiesList.Text.ToString());
                Address newAddress = new Address(tb_newCustAddress.Text,
                                           tb_newCustAddress2.Text,
                                           selectedCityId,
                                           Convert.ToInt32(tb_newCustZip.Text),
                                           tb_newCustPhone.Text,
                                           DateTime.Now,
                                           DataAccess.LoggedInUser,
                                           DateTime.Now,
                                           DataAccess.LoggedInUser);
                CustomersController.CreateAddress(newAddress);

                Customer newCust = new Customer(tb_newCustName.Text,
                                            Address.LastInsertedId,
                                            activeStatus,
                                            DateTime.Now,
                                            DataAccess.LoggedInUser,
                                            DateTime.Now,
                                            DataAccess.LoggedInUser);
                CustomersController.CreateCustomer(newCust);
              
            }
            catch(Exception x)
            {
                MessageBox.Show("There was an error: " + x.Message);
            }

            MessageBox.Show("The following Customer information was added: \n" +
                                "Customer Name: " + tb_newCustName.Text + "\n" +
                                "City" + City.GetCityIdFromName(cb_citiesList.SelectedItem.ToString()) + "\n" +
                                "Active? " + activeStatus + "\n" +
                                "Created Date:" + DateTime.Now.ToUniversalTime() + "\n" +
                                "Created By:" + DataAccess.LoggedInUser + "\n" +
                                "Last Updated Date: " + DateTime.Now.ToUniversalTime() + "\n" +
                                "Last Updated By: " + DataAccess.LoggedInUser);

            this.Close();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void cb_citiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(cb_citiesList.Text != null)
            {
                tb_countryName.Text = Country.GetCountryNameFromCity(cb_citiesList.Text.ToString());

            }
            else
            {
                cb_citiesList.SelectedItem = "";
            }

        }




        //Validating methods
        private void tb_newCustName_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (tb_newCustName.Text.Length == 0)
            {
                error = "Please enter a name";
                e.Cancel = true;
            }
            errPr_addCustomer.SetError((Control)sender, error);
        }

        private void tb_newCustAddress_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (tb_newCustAddress.Text.Length == 0)
            {
                error = "Please enter an address for customer.";
                e.Cancel = true;
            }
            errPr_addCustomer.SetError((Control)sender, error);
        }

      
        /*This code is not used due to zip codes being different in various locations. But I've included the code just as practice of 
         regular expressions.*/

        //private void tb_newCustZip_Validating(object sender, CancelEventArgs e)
        //{
        //    string error = null;
        //    Regex pattern = new Regex(@"\d{4}[0-9]");
        //    if (tb_newCustZip.Text.Length == 0 ||  !pattern.IsMatch(tb_newCustZip.Text)) 
        //    {
        //        error = "Please enter a zip code in proper format.";
        //        e.Cancel = true;
        //    }
        //    errPr_addCustomer.SetError((Control)sender, error);
        //}


        private void cb_citiesList_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (cb_citiesList.Text.Length == 0)
            {
                error = "Please select a city.";
                e.Cancel = true;
            }
            errPr_addCustomer.SetError((Control)sender, error);
        }
    }
}
