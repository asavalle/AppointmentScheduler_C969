using AppointmentScheduler_C969.Models;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Controllers
{
    /*
        * This Class handles communication between the user (AddCustomer.cs view) and the database, 
        * utilizing the data model (Customer.cs). It is responsible for formatting data into a usable format for the Customer class
        * to use in it's queries.
     */

    class CustomersController
    {


        public static void CreateCustomer(Customer customer)
        {
            Customer.InsertCustomerRecord(customer);
        }

        public static void CreateCity(City city)
        {
            City.InsertCityRecord(city);
        }

        public static void CreateCountry(Country country)
        {
            Country.InsertCountryRecord(country);
        }

        public static void CreateAddress(Address address)
        {
            Address.InsertAddressRecord(address);

        }


        public static void DeleteCustomer(DataGridViewSelectedRowCollection selectedRow)
        {

        }

        public static void ModifyCustomerName(string name)
        {
            Customer.UpdateCustomerName(name);
        }
        public static void ModifyCustomerAddress(string address, string address2, string city, string zip, string phone)
        {
            Customer.UpdateCustomerAddress(address, address2, city, zip, phone);
        }

    }
}
