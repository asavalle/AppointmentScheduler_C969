using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AppointmentScheduler_C969.Views;
using System.Globalization;

namespace AppointmentScheduler_C969
{
    public static class DataAccess
    {
        public static string loggedInUser { get; set; }
        public static bool loginSuccessful;


        public static void Login(string userName, string password)
        {
            string dbConnStr = "server=localhost; database=client_schedule;uid=sqlUser;pwd=passw0rd!;";

            using (var cnn = new MySqlConnection(dbConnStr))
            {
                try
                {
                    //Check that the Username and Password fields are not empty
                    if (userName != "" && password != "")
                    {
                        cnn.Open();
                        using var uname_cmd = new MySqlCommand("select userName from client_schedule.user;", cnn);
                        using var pass_cmd = new MySqlCommand("select password from client_schedule.user;", cnn);
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
                            if(CultureInfo.CurrentCulture.Name == "en-US")
                            {
                                MessageBox.Show("Username or Password does not match.");
                                
                            }
                            else if(CultureInfo.CurrentCulture.Name == "es-ES")
                            {
                                MessageBox.Show("El nombre de usuario o la contraseña no coinciden.");

                            }
                            loginSuccessful = false;

                        }
                    }
                    else
                    {
                        if (CultureInfo.CurrentCulture.Name == "en-US")
                        {
                            MessageBox.Show("Username or Password cannot be empty. Connection Failed.");

                        }
                        else if (CultureInfo.CurrentCulture.Name == "es-ES")
                        {
                            MessageBox.Show("El nombre de usuario o la contraseña no pueden estar vacíos. La conexión falló.");

                        }
                    }

                    cnn.Close();
                }
                catch
                {

                }

            }

        }

        
    }
}
