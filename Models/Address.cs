using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Models
{
    class Address
    {
        public static int LastInsertedId;
        public static int SelectedAddressID;
        public int AddressId { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public int CityId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }


        public Address() { }

        public Address(string address, string address2, int cityId, string zip, string phone,DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
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

        public static DataTable GetAddresses()
        {
            DataTable addrTable = new DataTable();
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                using (var getAddrCmd = new MySqlCommand("SELECT address.addressId, address.address, address.address2,address.cityId,city.city,address.postalCode FROM address, city where address.cityId = city.cityId ORDER BY address.addressId asc;", DataAccess.conn))
                {
                    MySqlDataAdapter sqlAdpt = new MySqlDataAdapter(getAddrCmd);
                    sqlAdpt.Fill(addrTable);

                }

            }
            catch (MySqlException myEx)
            {
                MessageBox.Show(myEx.Message);
            }

            return addrTable;
        }

        public static void InsertAddressRecord(Address newAddress) 
        {
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                var formatCreateDate = newAddress.CreateDate.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                var formatLastUpDate = newAddress.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");

                var insert_cmd = new MySqlCommand($"INSERT INTO client_schedule.address VALUES(null,'{newAddress.StreetAddress}','{newAddress.StreetAddress2}','{newAddress.CityId}','{newAddress.PostalCode}','{newAddress.Phone}','{formatCreateDate}','{newAddress.CreatedBy}','{formatLastUpDate}','{newAddress.LastUpdateBy}')", DataAccess.conn);
                var insert = insert_cmd.ExecuteNonQuery();
                LastInsertedId = (int)insert_cmd.LastInsertedId;
                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("In Address Class: "+ ex.Message);
            }


        }

        public static int GetAddressIdFromCustomerId(int custId)
        {
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                var get_cmd = new MySqlCommand($"SELECT addressId FROM customer WHERE customerId = {custId}", DataAccess.conn);
                var adrId = get_cmd.ExecuteReader();
                adrId.Read();
                int id = Convert.ToInt32(adrId.GetValue(0));
                adrId.Close();
                return id;
            }
            catch(MySqlException myEx)
            {
                MessageBox.Show(myEx.Message);
            }
            return -1;
        }

        public static void DeleteCustomerAddress(int customerAddressId)
        {
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                using var delAdd_cmd = new MySqlCommand($"DELETE FROM address WHERE addressId = {customerAddressId}", DataAccess.conn);
                var update = delAdd_cmd.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
