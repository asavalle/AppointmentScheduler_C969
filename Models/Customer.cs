using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Models
{
    class Customer
    {
        public int CustomerId { get; set; }
        public static List<string> CustomerName { get; set; } = new List<string>();
        public int AddressId { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }


        public Customer()
        {
            
        }

        public Customer(int customerId, string customerName, int addressId, bool active, DateTime createDate, 
            string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            //this.CustomerId = customerId;
            CustomerName = CustomerName;
            this.AddressId = addressId;
            this.Active = active;
            this.CreateDate = createDate;
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
                    "address.address as Address, city.city as City, address.postalCode as Zip, " +
                    "address.phone as Phone FROM((customer INNER JOIN address on address.addressId = customer.addressId) " +
                    "INNER JOIN city ON address.cityId = city.cityId)", DataAccess.conn))
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

                Customer.CustomerName.Add(row.Field<string>("Name"));

            }
        }

    }
}
