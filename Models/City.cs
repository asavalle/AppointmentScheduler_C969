using MySql.Data.MySqlClient;
using System;
using System.Data;
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

        //public static BindingList<City> listOfCities { get; set; } = new BindingList<City>();
        public static DataTable dtCities = new DataTable();
        public City() { }

        public City(int id, string cName, int countryId, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
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
            dtCities.Clear();
            try
            {

                using (var getAptCmd = new MySqlCommand("SELECT * FROM client_schedule.city;", DataAccess.conn))
                {
                    MySqlDataAdapter sqlAdpt = new MySqlDataAdapter(getAptCmd);
                    sqlAdpt.Fill(dtCities);

                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        public static DataTable GetCities()
        {
            DataTable cityTable = new DataTable();
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                using (var getcityCmd = new MySqlCommand("SELECT * FROM city", DataAccess.conn))
                {
                    MySqlDataAdapter sqlAdpt = new MySqlDataAdapter(getcityCmd);
                    sqlAdpt.Fill(cityTable);

                }

            }
            catch (MySqlException myEx)
            {
                MessageBox.Show(myEx.Message);
            }

            return cityTable;
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

                var insert_cmd = new MySqlCommand($"INSERT IGNORE INTO city VALUES( null,'{city.CityName}', {city.CountryId},'{formatCreateDate}','{city.CreatedBy}','{formatLastUpDate}','{city.LastUpdateBy}')", DataAccess.conn);
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

        public static int GetCityIdFromAddressId(int addrId)
        {
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                var get_cmd = new MySqlCommand($"SELECT cityId FROM address WHERE addressId = {addrId}", DataAccess.conn);
                var cityId = get_cmd.ExecuteReader();
                cityId.Read();
                int id = Convert.ToInt32(cityId.GetValue(0));
                cityId.Close();
                return id;
            }
            catch (MySqlException myEx)
            {
                MessageBox.Show(myEx.Message);
            }
            return -1;

        }
    }
}
