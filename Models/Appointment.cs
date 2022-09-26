using AppointmentScheduler_C969.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace AppointmentScheduler_C969.Models
{
    class Appointment
    {
        public static int SelectedAppointmentId { get; set; }
        public static DateTime SelectedAppointmentDateCreated { get; set; }
        public int AppointmentId { get; set; } //autoincrements on the database side
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string URL { get; set; }
        public static List<string> StartTimes { get; set; } = new List<string>();
        public static List<string> EndTimes { get; set; } = new List<string>();
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
       
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        //new Appointment constructor
        public Appointment() { }
        public Appointment(int customerId, string customerName, string title, string description, string location, string contact, string type, string url, DateTime start, 
                            DateTime end, DateTime createDate,string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.Title = title;
            this.Description = description;
            this.Location = location;
            this.Contact = contact;
            this.Type = type;
            this.URL = url;
            this.StartTime = start;
            this.EndTime = end;
            this.CreateDate = createDate;
            this.CreatedBy = createdBy;
            this.LastUpdate = lastUpdate;
            this.LastUpdateBy = lastUpdateBy;
        }

        /***********************************************************************
         *************** Function to build list of available times *************
         **********************************************************************/
        public static void GenerateTimes(DateTime aptDate)
        {
            var culture = new System.Globalization.CultureInfo("en-Us");

            DateTime date = new DateTime(aptDate.Year, aptDate.Month, aptDate.Day, 05, 0, 0);
            var hours = 25;
            while (hours > 0)
            {

                StartTimes.Add(date.ToShortTimeString());
                EndTimes.Add(date.ToShortTimeString());

                date = date.AddMinutes(30);
                hours--;
            }

        }



        /***********************************************************************
        *************** Functions to Query Database ****************************
        ***********************************************************************/
        public static DataTable GetAppoitments()
        {                
            DataTable aptTable = new DataTable();
            if(DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {

                var getAptCmd = new MySqlCommand("SELECT appointmentId, customer.customerName,appointment.title,appointment.description, appointment.contact, " +
                    "appointment.type, appointment.start, appointment.end, appointment.start as appointment_Date,appointment.location, appointment.url " +
                    "FROM client_schedule.appointment inner join customer where customer.customerId = appointment.customerId; ", DataAccess.conn);


                MySqlDataAdapter sqlAdp = new MySqlDataAdapter(getAptCmd);

                sqlAdp.Fill(aptTable);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return aptTable;
        }
        
       
        public static Appointment GetCurrentAppointment(int ID) {

            Appointment currentAppointment = new Appointment();
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                using (var select_cmd = new MySqlCommand($"SELECT * FROM client_schedule.appointment WHERE appointmentId = {ID}", DataAccess.conn))
                {
                    MySqlDataReader select = select_cmd.ExecuteReader();
                    
                    while (select.Read())
                    {


                        currentAppointment.AppointmentId = select.GetFieldValue<int>("appointmentId");
                        currentAppointment.CustomerId = select.GetFieldValue<int>("customerId");                        
                        currentAppointment.Contact = select.GetFieldValue<string>("contact");
                        currentAppointment.Title = select.GetFieldValue<string>("title");
                        currentAppointment.Type = select.GetFieldValue<string>("type");
                        currentAppointment.Description = select.GetFieldValue<string>("description");
                        currentAppointment.CreateDate = select.GetFieldValue<DateTime>("createDate");
                        currentAppointment.StartTime = select.GetFieldValue<DateTime>("start");
                        currentAppointment.EndTime = select.GetFieldValue<DateTime>("end");
                        currentAppointment.CreatedBy = select.GetFieldValue<string>("createdBy");
                        currentAppointment.LastUpdate = select.GetFieldValue<DateTime>("lastUpdate");
                        currentAppointment.LastUpdateBy = select.GetFieldValue<string>("lastUpdateBy");
                        currentAppointment.URL = select.GetFieldValue<string>("url");
                    }
                    SelectedAppointmentDateCreated = currentAppointment.CreateDate;
                    select.Close();
                    currentAppointment.CustomerName = Customer.GetCustomerName(currentAppointment.CustomerId);
                }
                    
                DataAccess.CloseConnection();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message);
            }
            

            return currentAppointment;

        }
       
        public static DataTable GetAppointmensByWeek() {

            DataTable aptsByWeek = new DataTable();
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {

                var getWeekAptsCmd = new MySqlCommand(
                    "SELECT appointment.appointmentId, customer.customerName, appointment.title, " +
                    "appointment.description, appointment.contact, appointment.location, appointment.type, " +
                    "appointment.start, appointment.end,appointment.start as appointment_Date, appointment.url " +
                    "FROM client_schedule.appointment, client_schedule.customer " +
                    "where yearweek(start, 0) = yearweek(curdate(), 0) and appointment.customerId = customer.customerId; ", DataAccess.conn);


                MySqlDataAdapter sqlAdp = new MySqlDataAdapter(getWeekAptsCmd);

                sqlAdp.Fill(aptsByWeek);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return aptsByWeek;

        }

        public static DataTable GetAppointmentsByMonth()
        {
            DataTable aptsByMonth = new DataTable();
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {

                var getMonthAptsCmd = new MySqlCommand(
                    "SELECT appointment.appointmentId, customer.customerName, appointment.title, " +
                    "appointment.description, appointment.contact, appointment.location, appointment.type, " +
                    "appointment.start, appointment.end,appointment.start as appointment_Date, appointment.url " +
                    "FROM client_schedule.appointment, client_schedule.customer " +
                    "WHERE MONTH(start) = MONTH(now()) and appointment.customerId = customer.customerId; ", DataAccess.conn);


                MySqlDataAdapter sqlAdp = new MySqlDataAdapter(getMonthAptsCmd);

                sqlAdp.Fill(aptsByMonth);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return aptsByMonth;
        }


        /***********************************************************************
         *************** Functions Create/Update/Delete appointments ***********
         **********************************************************************/
        public static void InsertAppointment(Appointment apt)
        {
            int userId = User.GetUserId();
            var formatSDate = apt.StartTime.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            var formatEDate = apt.EndTime.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            var formatCreateDate = apt.CreateDate.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
            var formatLastUpDate = apt.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");

            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                var insert_cmd = new MySqlCommand($"INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES({apt.CustomerId},{userId},'{apt.Title}','{apt.Description}','{apt.Location}','{apt.Contact}','{apt.Type}','{apt.URL}','{formatSDate}','{formatEDate}','{formatCreateDate}','{apt.CreatedBy}','{formatLastUpDate}','{apt.LastUpdateBy}')", DataAccess.conn);
                var insert = insert_cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DeleteAppointment(int aptId)
        {
            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            if (aptId >= 0)
            {
                try
                {
                    DialogResult deleteConfirm = MessageBox.Show($"Do you want to delete Appointment {aptId}", "Delete Confirmation.", MessageBoxButtons.YesNo);
                    if (deleteConfirm == DialogResult.Yes)
                    {
                        var del_cmd = new MySqlCommand($"DELETE FROM client_schedule.appointment WHERE appointmentId = {aptId};", DataAccess.conn);
                        var delete = del_cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("No record was selected.");
            }
        }

        public static void UpdateAppointment(Appointment apt)
        {
            int userId = User.GetUserId();
            var formatSDate = apt.StartTime.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            var formatEDate = apt.EndTime.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            var formatCreateDate = apt.CreateDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            var formatLastUpDate = apt.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            var now = DateTime.Now;

            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                var update_cmd = new MySqlCommand($"UPDATE client_schedule.appointment SET appointment.customerId = {apt.CustomerId}, appointment.title = '{apt.Title}', appointment.contact = '{apt.Contact}', appointment.type = '{apt.Type}', appointment.start = '{formatSDate}', appointment.end = '{formatEDate}',appointment.createDate= '{formatCreateDate}', appointment.lastUpdate = '{formatLastUpDate}' WHERE appointment.appointmentId = {apt.AppointmentId}; ", DataAccess.conn);
                var update = update_cmd.ExecuteNonQuery();
                DataAccess.CloseConnection();

            }
            catch (MySqlException exsql)
            {
                MessageBox.Show(exsql.Message);
            }



            //pull selected data from database. Pass to controller.
            MessageBox.Show(
                apt.CustomerName + "\n" +
                apt.Contact + "\n" +
                apt.Title + "\n" +
                apt.Type + "\n" +
                apt.Description + "\n" +
                apt.CreateDate + "\n" +
                apt.StartTime + "\n" +
                apt.EndTime + "\n" +
                apt.Location + "\n" +
                apt.URL + "\n"
                );

        }


    }
}
