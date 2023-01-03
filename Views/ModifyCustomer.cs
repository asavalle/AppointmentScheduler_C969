using AppointmentScheduler_C969.Controllers;
using AppointmentScheduler_C969.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Views
{
    public partial class ModifyCustomer : Form
    {
        public ModifyCustomer()
        {
            InitializeComponent();

            try
            {
                City.UpdateListOfCities();
                BindingSource allCities = new BindingSource();
                DataTable customersTable = Customer.GetCustomers(); //creates a table of all customers to allow access to fields.
                DataTable addressTable = Address.GetAddresses(); //creates a table of all addresses.
                DataTable cityTable = City.GetCities(); //Creates a table of all cities.

                //LAMBDA expressions used here to quickly select individual fields, as needed, using LINQ, rather than creating individual methods to select the required data.
                var selectedAddr = addressTable.AsEnumerable().Where(x => x.Field<int>("addressId") == Customer.SelectedCustomerAddressId).FirstOrDefault();
                var selectedCity = cityTable.AsEnumerable().Where(x => x.Field<int>("cityId") == Customer.SelectedCustomerCityId).FirstOrDefault();
                var selectedCustomer = customersTable.AsEnumerable().Where(x => x.Field<int>("Customer_ID") == Customer.SelectedCustomerID).FirstOrDefault();
                allCities.DataSource = City.dtCities;
                cb_modCustCityList.DataSource = allCities;
                cb_modCustCityList.ValueMember = "city";
                chk_ActiveUser.Checked = selectedCustomer.Field<bool>("active");
                tb_custName.Text = Customer.GetCustomerNameById(Customer.SelectedCustomerID);
                
                   
     

                tb_custAddr1.Text = selectedAddr.Field<string>("address");
                tb_custAddr2.Text = selectedAddr.Field<string>("address2");
                cb_modCustCityList.SelectedValue = selectedCity.Field<string>("city").ToString();
                tb_countryName.Text = Country.GetCountryNameFromCity(selectedCity.Field<string>("city"));
                tb_postCode.Text = selectedAddr.Field<string>("postalCode");
                tb_phoneNum.Text = selectedCustomer.Field<string>("phone");

            }
            catch(ArgumentNullException n)
            {
                MessageBox.Show("Please select a row.");
                this.Close();

            }

        }


        private void btn_modCustomerAddCity_Click(object sender, EventArgs e)
        {
            AddCity newCity = new AddCity();
            newCity.ShowDialog();
        }

        private void btn_editModCust_Click(object sender, EventArgs e)
        {
            foreach(Control con in gb_updateAddr.Controls)
            {
                if(con is TextBox)
                {
                    con.Enabled = true;
                }
                
            }
            tb_custName.Enabled = true;
            cb_modCustCityList.Enabled = true;
            btn_updateName.Visible = true;
            btn_updateAddr.Visible = true;
            btn_modCustomerAddCity.Visible = true;
            chk_ActiveUser.Enabled = true;

        }

        private void ll_modCustCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btn_updateName_Click(object sender, EventArgs e)
        {
            CustomersController.ModifyCustomerName(tb_custName.Text);
            Customer.UpdateActiveCustomerRecord(chk_ActiveUser.Checked);
           DialogResult updated = MessageBox.Show($"Customer's name has been updated to {tb_custName.Text}. Would you like exit?","Continue Updating?",MessageBoxButtons.YesNo);
            if (updated == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_updateAddr_Click(object sender, EventArgs e)
        {
            CustomersController.ModifyCustomerAddress(tb_custAddr1.Text, tb_custAddr2.Text, cb_modCustCityList.Text, tb_postCode.Text, tb_phoneNum.Text);
            DialogResult updated = MessageBox.Show($"Customer's address has been updated to {tb_custAddr1.Text} \n {tb_custAddr2.Text} \n  {cb_modCustCityList.Text}, { tb_postCode.Text}\n {tb_phoneNum.Text}.\n Would you like exit?", "Continue Updating?", MessageBoxButtons.YesNo);
            if (updated == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cb_modCustCityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_countryName.Text = Country.GetCountryNameFromCity(cb_modCustCityList.Text);

        }

        private void chk_ActiveUser_CheckStateChanged(object sender, EventArgs e)
        {

        }
    }
}
