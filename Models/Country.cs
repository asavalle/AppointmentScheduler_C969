using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Models
{
    class Country
    {
        public static int CurrentCountryId { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
        public static List<string> listOfCountries { get; set; } = new List<string>();

        public Country()
        {

        }
        public Country(string countryName, DateTime createdDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this.CountryName = countryName;
            this.CreateDate = createdDate;
            this.CreatedBy = createdBy;
            this.LastUpdate = lastUpdate;
            this.LastUpdateBy = lastUpdateBy;
        }


        public static void InsertCountryRecord(Country country)
        {
            //return country ID to property in AddCustomer's form.

            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            { //TODO: Need to figure out how to validate country before sending to DB
                var insert_cmd = new MySqlCommand($"INSERT IGNORE into client_schedule.country (country, createDate,createdBy,lastUpdate,lastUpdateBy) VALUES('{country.CountryName}','{country.CreateDate}','{country.CreatedBy}','{country.LastUpdate}','{country.LastUpdateBy}') ", DataAccess.conn);
                var insert = insert_cmd.ExecuteNonQuery();
                DataAccess.CloseConnection();

            }
            catch (MySqlException exsql)
            {
                MessageBox.Show(exsql.Message);
            }
            CurrentCountryId = country.CountryId;
        }

        public static void UpdateListOfCountries()
        {
            DataTable countryTable = new DataTable();
            try
            {

                using (var getAptCmd = new MySqlCommand("SELECT * FROM client_schedule.country;", DataAccess.conn))
                {
                    MySqlDataAdapter sqlAdpt = new MySqlDataAdapter(getAptCmd);
                    sqlAdpt.Fill(countryTable);
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            foreach (DataRow row in countryTable.Rows)
            {
                listOfCountries.Add(row.Field<string>("country"));
            }

            

        }
    }
}
