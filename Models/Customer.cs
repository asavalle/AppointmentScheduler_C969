using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Models
{
    /*
     This class is responsible for all the database query/communication for the CustomerController class. The controller formats data
    as necessary for this class to utilize in it's queries.
     */


    class Customer
    {
        public static int SelectedCustomerID;
        public static int SelectedCustomerAddressId;
        public static int SelectedCustomerCityId;

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int CityId { get; set; }
        public int AddressId { get; set; }
        public int Active { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
        public static List<string> Names { get; set; } = new List<string>();


        public Customer()
        {

        }

        public Customer(string customerName, int addressId, int active, DateTime createDate,
            string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this.CustomerName = customerName;
            this.AddressId = addressId;
            this.Active = active;
            this.CreateDate = createDate;
            this.CreatedBy = DataAccess.LoggedInUser;
            this.LastUpdate = lastUpdate;
            this.LastUpdateBy = lastUpdateBy;
        }
        //Function to populate Customer table from database
        public static DataTable GetCustomers()
        {
            DataTable custTable = new DataTable();
            try
            {

                using (var getAptCmd = new MySqlCommand("SELECT customer.customerId as Customer_ID, customer.customerName as Name, " +
                    "address.address as Address, city.city as City, country.country, " +
                    "address.phone as Phone, customer.active " +
                    "FROM((customer INNER JOIN address on address.addressId = customer.addressId) " +
                    "INNER JOIN city ON address.cityId = city.cityId)" +
                    "INNER JOIN country ON city.countryId = country.countryId", DataAccess.conn))
                {
                    MySqlDataAdapter sqlAdpt = new MySqlDataAdapter(getAptCmd);
                    sqlAdpt.Fill(custTable);
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return custTable;
        }


        public static void InsertCustomerRecord(Customer cust) 
        {
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                var formatCreateDate = cust.CreateDate.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                var formatLastUpDate = cust.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");

                var insert_cmd = new MySqlCommand($"INSERT INTO customer VALUES(null,'{cust.CustomerName}','{cust.AddressId}','{cust.Active}','{formatCreateDate}','{cust.CreatedBy}','{formatLastUpDate}','{cust.LastUpdateBy}')", DataAccess.conn);
                var insert = insert_cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("In Customer Class: " + ex.Message);
            }
        }


        public static void DeleteCustomerRecord() { }

        public static void UpdateCustomerRecord() 
        {
        
        }

        public static void UpdateCustomerName(string name) 
        {
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                using var update_cmd = new MySqlCommand($"UPDATE client_schedule.customer SET customerName = '{name}' WHERE customerId = '{Customer.SelectedCustomerID}'", DataAccess.conn);
                var update = update_cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void UpdateCustomerAddress(string address, string address2,string city, string zip, string phone)
        {
            int newCityId = City.GetCityIdFromName(city);

            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                using var update_cmd = new MySqlCommand($"UPDATE client_schedule.address SET address = '{address}', address2 = '{address2}',cityId = {newCityId}, postalCode = '{zip}', phone = '{phone}',createDate = NOW(), createdBy ='{DataAccess.LoggedInUser}', lastUpdate= NOW(), lastUpdateBy = '{DataAccess.LoggedInUser}' WHERE addressId = {Customer.SelectedCustomerAddressId}", DataAccess.conn);
                var update = update_cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static int GetCustomerId(string name)
        {
            int id = -1;
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();          
            }
            
           
                using (var getId_cmd = new MySqlCommand($"select customerId from client_schedule.customer where customerName = '{name}'", DataAccess.conn)) 
                {
                    MySqlDataAdapter sqlAdp = new MySqlDataAdapter(getId_cmd);
                
                
                MySqlDataReader custId = getId_cmd.ExecuteReader();
                while (custId.Read())
                {
                    id = Convert.ToInt32(custId.GetValue(0));
                }
                    
                    custId.Close();
                }
                                
                
                DataAccess.CloseConnection();
           

            
            return id;

        }

        public static string GetCustomerName(int id)
        {
            string name ="";
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            using (var getName_cmd = new MySqlCommand($"select customerName from client_schedule.customer where customerId = '{id}'", DataAccess.conn))
            {
                MySqlDataReader custName = getName_cmd.ExecuteReader();
                while (custName.Read())
                {
                    name = custName.GetString(0);
                }
                
                custName.Close();
             DataAccess.CloseConnection();
            
            }
            
            return name;

            
           
        }

        public static void GetCustomerList()
        {
            DataTable dt = Customer.GetCustomers();

            foreach (DataRow row in dt.Rows)
            {

                Customer.Names.Add(row.Field<string>("Name"));

            }
        }

    }
}
