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
        public int active { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }

        public static int CurrentUserId { get; set; }

        public User(string UserName, string Password, int Active, DateTime CreateDate, string CreatedBy, DateTime LastUdpate, string LastUpdateBy)
        {
            //creates a constructer with user provided data. Database will handle missing data
            this.userName = UserName;
            this.password = Password;
            this.active = Active;
            this.createDate = CreateDate;
            this.createdBy = CreatedBy;
            this.lastUpdate = LastUdpate;
            this.lastUpdateBy = LastUpdateBy;
        }

        public static void InsertUserRecord(User user)
        {
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                var formatCreateDate = user.createDate.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                var formatLastUpDate = user.lastUpdate.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                var insert_cmd = new MySqlCommand($"INSERT INTO user VALUES(null,'{user.userName}','{user.password}','{user.active}','{formatCreateDate}','{user.createdBy}','{formatLastUpDate}','{user.lastUpdateBy}')", DataAccess.conn);
                var insert = insert_cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("In User Class: " + ex.Message);
            }
        }
        public static void UpdateUserRecord()
        {

        }
        public static void DeleteUserRecord()
        {

        }



        //Function to populate Users table from database
        public static DataTable GetUsers()
        {
            DataTable usersTable = new DataTable();
            try
            {

                using (var getAptCmd = new MySqlCommand("SELECT userId, userName, active,createDate FROM client_schedule.user", DataAccess.conn))
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

        public static DataTable getAllUserInfo() {
            //Add code to retrieve data from the database and add it to the list

            DataTable usrInfoTable = new DataTable();
            try
            {

                using (var getUsrCmd = new MySqlCommand("SELECT userId, userName FROM client_schedule.user", DataAccess.conn))
                {
                    MySqlDataReader reader = getUsrCmd.ExecuteReader();
                    usrInfoTable.Load(reader);
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

          
            return usrInfoTable;
        }

        public static int GetUserId()
        {
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                var getUserId_cmd = new MySqlCommand($"select userId from client_schedule.user where userName = '{DataAccess.LoggedInUser}'", DataAccess.conn);
                var userId = getUserId_cmd.ExecuteReader();
                userId.Read();
                int id = Convert.ToInt32(userId.GetValue(0));
                userId.Close();

                CurrentUserId = id;
                return id;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }

        }

        public static string GetUserNameById(int id)
        {
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {

                var getUsrName_Cmd = new MySqlCommand($"SELECT userName FROM client_schedule.user WHERE userId = {id}", DataAccess.conn);
                var userName = getUsrName_Cmd.ExecuteReader();
                userName.Read();
                string name = userName.GetString(0);
                userName.Close();

                return name;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;

            }

        }
    }
}
