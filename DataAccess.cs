using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AppointmentScheduler_C969.Views;
using System.Globalization;
using System.Data;
using System.Configuration;

namespace AppointmentScheduler_C969
{
    public static class DataAccess
    {
        public static string loggedInUser { get; set; }
        public static bool loginSuccessful;
        private static string dbConnStr = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        public static MySqlConnection conn = new MySqlConnection(dbConnStr);

        /*
        * Query's the database to validate and populate DataGridViews.
        */

        public static void OpenConnection()
        {
            try
            {
                conn.Open();
                //MessageBox.Show("Connection successful!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void CloseConnection()
        {
            try
            {
                using (var cnn = new MySqlConnection(dbConnStr))
                {                   
                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Function to validate user login
        public static void Login(string userName, string password)
        {

            try
            {

                //Check that the Username and Password fields are not empty
                if (userName != "" && password != "")
                {
                    OpenConnection();
                    using var uname_cmd = new MySqlCommand("select userName from client_schedule.user;", conn);
                    using var pass_cmd = new MySqlCommand("select password from client_schedule.user;", conn);
                    string uname = uname_cmd.ExecuteScalar().ToString();
                    string pass = pass_cmd.ExecuteScalar().ToString();

                    //compare entered username and password to database values
                    if (userName == uname.ToString() && password == pass.ToString())
                    {
                        loggedInUser = uname;
                        loginSuccessful = true;
                    }
                    else
                    {
                        if (CultureInfo.CurrentCulture.Name == "en-US")
                        {
                            MessageBox.Show("Username or Password does not match.");
                            CloseConnection();

                        }
                        else if (CultureInfo.CurrentCulture.Name == "es-ES")
                        {
                            MessageBox.Show("El nombre de usuario o la contraseña no coinciden.");
                            CloseConnection();

                        }
                        loginSuccessful = false;

                    }
                }
                else
                {
                    if (CultureInfo.CurrentCulture.Name == "en-US")
                    {
                        MessageBox.Show("Username or Password cannot be empty. Connection Failed.");
                        CloseConnection();
                    }
                    else if (CultureInfo.CurrentCulture.Name == "es-ES")
                    {
                        MessageBox.Show("El nombre de usuario o la contraseña no pueden estar vacíos. La conexión falló.");
                        CloseConnection();

                    }
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        //Function to populate Appointments table from database
        public static DataTable GetAppoitments()
        {
            DataTable aptTable = new DataTable();
            try
            {   
                
                using (var getAptCmd = new MySqlCommand("select * from client_schedule.appointment", conn))
                {
                    MySqlDataReader reader = getAptCmd.ExecuteReader();
                    aptTable.Load(reader);
                }                                             
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return aptTable;
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
                    "INNER JOIN city ON address.cityId = city.cityId)", conn))
                {
                    MySqlDataReader reader = getAptCmd.ExecuteReader();
                    custTable.Load(reader);
                }
                
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return custTable;
        }

        //Function to populate Users table from database
        public static DataTable GetUsers() 
        { 
            DataTable usersTable = new DataTable();
            try
            {               
                
                using (var getAptCmd = new MySqlCommand("SELECT * FROM client_schedule.user", conn))
                {
                    MySqlDataReader reader = getAptCmd.ExecuteReader();
                    usersTable.Load(reader);
                }
                
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return usersTable;
        }


 


    }
}
