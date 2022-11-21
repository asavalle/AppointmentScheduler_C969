using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentScheduler_C969.Models
{
    class Address
    {
        public int AddressId { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public int CityId { get; set; }
        public int PostalCode { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }


        public Address() { }

        public Address(string address, string address2, int cityId, int zip, string phone,DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this.StreetAddress = address;
            this.StreetAddress2 = address2;
            this.CityId = cityId;
            this.PostalCode = zip;
            this.Phone = phone;
            this.CreateDate = createDate;
            this.CreatedBy = createdBy;
            this.LastUpdate = lastUpdate;
            this.LastUpdateBy = lastUpdateBy;

        }


        public static void InsertAddressRecord() { }


    }
}
