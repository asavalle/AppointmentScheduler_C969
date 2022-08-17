using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentScheduler_C969.Models
{
    class Customer
    {
        public int CustomerId { get; set; }
        public List<string> CustomerName { get; set; } = new List<string>();
        public int AddressId { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }


        public Customer()
        {
            
        }

        public Customer(int customerId, string customerName, int addressId, bool active, DateTime createDate, 
            string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this.CustomerName = CustomerName;
            this.AddressId = addressId;
            this.Active = active;
            this.CreateDate = createDate;
            this.LastUpdate = lastUpdate;
            this.LastUpdateBy = lastUpdateBy;
        }


    }
}
