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

        public static int GetCustomerId(string name)
        {

            if (!DataAccess.isConnOpen)
            {
                DataAccess.OpenConnection();          
            }

            var getId_cmd = new MySqlCommand($"select customerId from client_schedule.customer where customerName = '{name}'", DataAccess.conn);
            var custId = getId_cmd.ExecuteReader();
            custId.Read();
            int id = Convert.ToInt32(custId.GetValue(0));
            custId.Close();
            DataAccess.CloseConnection();
            return id;

        }

        public static string GetCustomerName(int id)
        {
            if (!DataAccess.isConnOpen)
            {
                DataAccess.OpenConnection();
            }
            var getName_cmd = new MySqlCommand($"select customerName from client_schedule.customer where customerId = '{id}'", DataAccess.conn);
            var custName = getName_cmd.ExecuteReader();
            custName.Read();
            string name = custName.GetString(0);
            custName.Close();
            DataAccess.CloseConnection();
            return name;
        }

        public static void GetCustomerList()
        {
            DataTable dt = DataAccess.GetCustomers();

            foreach (DataRow row in dt.Rows)
            {

                Customer.CustomerName.Add(row.Field<string>("Name"));

            }
        }

    }
}
