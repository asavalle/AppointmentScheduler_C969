using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Models
{
    class User
    {
        //property names match the column values in the client_schedule MySQL database user table.
        public int userID { get; set; } 
        public string userName { get; set; }
        public string password { get; set; }
        public bool active { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }


        public User(string UserName, string Password, bool Active, string CreatedBy)
        {
            //creates a constructer with user provided data. Database will handle missing data
            this.userName = UserName;
            this.password = Password;
            this.active = Active;
            this.createdBy = CreatedBy;
        }
        //Function to populate Users table from database
        public static DataTable GetUsers()
        {
            DataTable usersTable = new DataTable();
            try
            {

                using (var getAptCmd = new MySqlCommand("SELECT * FROM client_schedule.user", DataAccess.conn))
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

        public List<User> getAllUserInfo() {
            //Add code to retrieve data from the database and add it to the list
            List<User> userData = new List<User>(); 
            return userData;
        }

        public static int GetUserId()
        {
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }

            var getUserId_cmd = new MySqlCommand($"select userId from client_schedule.user where userName = '{DataAccess.LoggedInUser}'",DataAccess.conn);
            var userId = getUserId_cmd.ExecuteReader();
            userId.Read();
            int id = Convert.ToInt32(userId.GetValue(0));
            userId.Close();

            return id;
        }
    }
}
