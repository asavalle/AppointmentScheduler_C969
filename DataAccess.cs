using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AppointmentScheduler_C969.Views;
using System.Globalization;
using System.Data;
using System.Configuration;
using AppointmentScheduler_C969.Models;

namespace AppointmentScheduler_C969
{
    public static class DataAccess
    {
        public static string LoggedInUser { get; set; }
        public static bool loginSuccessful;
        private static readonly string dbConnStr = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        public static MySqlConnection conn = new MySqlConnection(dbConnStr);

        /*
        * Query's the database to validate and populate DataGridViews.
        */

        public static void OpenConnection()
        {
            try
            {
                using(var cnn = new MySqlConnection(dbConnStr))
                {
                    if(DataAccess.conn.State is ConnectionState.Closed)
                    {
                         conn.Open();

                    }
                }
                
            }
            catch(MySqlException err) 
            {
                MessageBox.Show(err.Message);
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
                    if (conn.State is ConnectionState.Closed)
                    {
                        OpenConnection();
                    }

                    using var uname_cmd = new MySqlCommand($"select userName from client_schedule.user where userName = '{userName}';", conn);
                    using var pass_cmd = new MySqlCommand($"select password from client_schedule.user WHERE userName = '{userName}';", conn);
                    string uname = uname_cmd.ExecuteScalar().ToString();
                    string pass = pass_cmd.ExecuteScalar().ToString();
                    
                        //compare entered username and password to database values
                        if (userName == uname.ToString() && password == pass.ToString())
                        {
                            if (User.IsActive(uname))
                            {
                                LoggedInUser = uname;
                                loginSuccessful = true;
                            }
                            else 
                            {
                                Report.FailedLoginLogReport(uname);
                                MessageBox.Show($"{uname} is not currently active and cannot access the system.");
                            }

                        }
                        else
                        {
                            if (CultureInfo.CurrentCulture.Name == "en-US")
                            {
                                MessageBox.Show("Username or Password does not match.");
                                Report.FailedLoginLogReport(uname);

                                CloseConnection();

                            }
                            else if (CultureInfo.CurrentCulture.Name == "es-ES")
                            {
                                Report.FailedLoginLogReport(uname);
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
            finally
            {
                CloseConnection();
            }
        }

        



    }
}
