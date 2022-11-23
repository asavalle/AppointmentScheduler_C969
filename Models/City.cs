using System;
using System.Collections.Generic;
using System.Text;

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
            //TODO: Query database and return list of cities and return as List to use as Datasource for combobox


        }


        public static void InsertCityRecord() 
        {
            //TODO: Query database for existing record. If not existing, insert record.
        }
    }
}
