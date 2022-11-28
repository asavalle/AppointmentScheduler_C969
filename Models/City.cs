using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Models
{
    class City
    {

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        public static List<string> listOfCities { get; set; } = new List<string>();

        public City() {  }

        public City(int id, string cName, int countryId,DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {
            this.CityId = id;
            this.CityName = cName;
            this.CountryId = countryId;
            this.CreateDate = createDate;
            this.CreatedBy = createdBy;
            this.LastUpdate = lastUpdate;
            this.LastUpdateBy = lastUpdatedBy;
        }
        
        public static void UpdateListOfCities() 
        {
            DataTable cityTable = new DataTable();
            try
            {

                using (var getAptCmd = new MySqlCommand("SELECT * FROM client_schedule.city;", DataAccess.conn))
                {
                    MySqlDataAdapter sqlAdpt = new MySqlDataAdapter(getAptCmd);
                    sqlAdpt.Fill(cityTable);
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            foreach (DataRow row in cityTable.Rows)
            {
                listOfCities.Add(row.Field<string>("city"));
            }

        }


        public static void InsertCityRecord(City city) 
        {
            //TODO: Query database for existing record. If not existing, insert record.

            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
               
                var formatCreateDate = city.CreateDate.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                var formatLastUpDate = city.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");

                var insert_cmd = new MySqlCommand($"INSERT INTO city VALUES( null,'{city.CityName}', {city.CountryId},'{formatCreateDate}','{city.CreatedBy}','{formatLastUpDate}','{city.LastUpdateBy}')", DataAccess.conn);
                var insert = insert_cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int GetCityIdFromName(string cityName)
        {
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                var selectCmd = new MySqlCommand($"SELECT cityId FROM client_schedule.city WHERE city = '{cityName}';", DataAccess.conn);
                MySqlDataReader select = selectCmd.ExecuteReader();

                int id = -1;
                while (select.Read())
                {
                    id = select.GetInt32(0);
                }
                select.Close();
                return id;
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
                return -1;
            }
        }
    }
}
