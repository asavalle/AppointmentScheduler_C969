using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace AppointmentScheduler_C969.Models
{
    /*
     This class is responsible for all the database query/communication for the AppointmentController class. The controller formats data
    as necessary for this class to utilize in it's queries.
     */
    class Appointment
    {
        public static int SelectedAppointmentId { get; set; }
        public static DateTime SelectedAppointmentDateCreated { get; set; }
        public int AppointmentId { get; set; } //autoincrements on the database side
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string CustomerName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //public string Location { get; set; }
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
        public static List<string> AppointmentTypes = new List<string>
        {
            "Consultation",
            "Follow-Up",
            "New Patient",
            "TeleHealth",
            "Standard Check-Up",
            "Yearly Check-Up"

        };
        public static Dictionary<int, string> Months = new Dictionary<int, string>
        {
            { 01, "January" },
            { 02, "Febuary" },
            { 03, "March" },
            { 04, "April" },
            { 05, "May" },
            { 06, "June" },
            { 07, "July" },
            { 08, "August" },
            { 09, "September" },
            { 10, "October" },
            { 11, "November" },
            { 12, "December" }

        };

        public string Doctor { get; set; } //selected doctor for appointment

        //new Appointment constructor
        public Appointment() { }
        public Appointment(int customerId, int userId, string customerName, string title, string description, string location, string contact, string type, string url, DateTime start,
                            DateTime end, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this.CustomerId = customerId;
            this.UserId = userId;
            this.CustomerName = customerName;
            this.Title = title;
            this.Description = description;
            this.Location = location;
            this.Contact = contact;
            this.Type = type;
            //this.URL = url;
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
            var hours = 49;
            while (hours > 0)
            {

                StartTimes.Add(date.ToShortTimeString());
                EndTimes.Add(date.ToShortTimeString());

                date = date.AddMinutes(15);
                hours--;
            }

        }



        /***********************************************************************
        *************** Functions to Query Database ****************************
        ***********************************************************************/
        public static DataTable GetAppointments()
        {
            DataTable aptTable = new DataTable();

            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                TimeZoneInfo currentTZone = TimeZoneInfo.Local;

                var getAptCmd = new MySqlCommand("SELECT appointmentId, " +
                    "customer.customerName as Patient," +
                    "appointment.userId as Doctor," +
                    "appointment.title," +
                    "appointment.description, " +
                    "appointment.contact, " +
                    "appointment.type, " +
                    "appointment.start, " +
                    "appointment.end," +
                    "appointment.start as appointment_Date," +
                    "appointment.location, " +
                    "appointment.url " +
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


        public static Appointment GetCurrentAppointment(int ID)
        {

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
                        currentAppointment.UserId = select.GetFieldValue<int>("userId");
                        currentAppointment.Contact = select.GetFieldValue<string>("contact");
                        currentAppointment.Title = select.GetFieldValue<string>("title");
                        currentAppointment.Type = select.GetFieldValue<string>("type");
                        currentAppointment.Description = select.GetFieldValue<string>("description");
                        currentAppointment.CreateDate = select.GetFieldValue<DateTime>("createDate").ToLocalTime();
                        currentAppointment.StartTime = select.GetFieldValue<DateTime>("start").ToLocalTime();
                        currentAppointment.EndTime = select.GetFieldValue<DateTime>("end").ToLocalTime();
                        currentAppointment.CreatedBy = select.GetFieldValue<string>("createdBy");
                        currentAppointment.LastUpdate = select.GetFieldValue<DateTime>("lastUpdate").ToLocalTime();
                        currentAppointment.LastUpdateBy = select.GetFieldValue<string>("lastUpdateBy");
                        currentAppointment.URL = select.GetFieldValue<string>("url");
                    }
                    SelectedAppointmentDateCreated = currentAppointment.CreateDate;
                    select.Close();
                    currentAppointment.CustomerName = Customer.GetCustomerNameById(currentAppointment.CustomerId);
                }

                DataAccess.CloseConnection();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message);
            }


            return currentAppointment;

        }

        public static DataTable GetAppointmensByWeek()
        {

            DataTable appointments = GetAppointments();
            DataTable aptsByWeek = new DataTable();

            try
            {

                IEnumerable<DataRow> filteredByWeek = from apts in appointments.AsEnumerable()
                                                      where Date.GetStartOfWeek(apts.Field<DateTime>("appointment_Date"),
                                                           DayOfWeek.Sunday) == Date.GetStartOfWeek(DateTime.Now, DayOfWeek.Sunday)
                                                      select apts;


                aptsByWeek = filteredByWeek.CopyToDataTable<DataRow>();


                return aptsByWeek;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;

            }


        }

        public static DataTable GetAppointmentsByMonth()
        {
            DataTable appointments = GetAppointments();
            DataTable aptsByMonth = new DataTable();
            try
            {
                IEnumerable<DataRow> filteredByMonth = from apts in appointments.AsEnumerable()
                                                       where apts.Field<DateTime>("appointment_Date").Month == DateTime.Now.Month
                                                       where apts.Field<DateTime>("appointment_Date").Year == DateTime.Now.Year
                                                       select apts;

                aptsByMonth = filteredByMonth.CopyToDataTable<DataRow>();

                return aptsByMonth;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }

        public static List<string> GetAppointmentByDoctorId()
        {
            var currentUserId = User.GetUserId();

            DataTable appointments = GetAppointments();
            List<string> AppointmentsByUser = new List<string>();

            foreach (DataRow row in appointments.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    if (row.Field<int>("userId") == currentUserId)
                    {
                        AppointmentsByUser.Add(item.ToString());
                    }
                }
            }
            return AppointmentsByUser;
        }

      
        //Override method for search function by string name
        public static DataTable GetAppointmentsByDoctorId(int id)
        {
            DataTable appointments = GetAppointments();
            DataTable aptsByDocId = new DataTable();
            try
            {
                IEnumerable<DataRow> filteredByDocId = from apts in appointments.AsEnumerable()
                                                       where apts.Field<int>("Doctor") == id
                                                       select apts;

                aptsByDocId = filteredByDocId.CopyToDataTable<DataRow>();

                return aptsByDocId;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataTable GetAppointmentByPatientName(string name)
        {
            DataTable appointments = GetAppointments();
            DataTable aptsByPatientId = new DataTable();
            try
            {
                IEnumerable<DataRow> filteredByPatientId = from apts in appointments.AsEnumerable()
                                                       where apts.Field<string>("Patient") == name
                                                       select apts;

                aptsByPatientId = filteredByPatientId.CopyToDataTable<DataRow>();

                return aptsByPatientId;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataTable GetAppointmentsByDoctor(string name)
        {
            //Convert name to id
            int DoctorId = User.GetUserIDbyName(name);

            //return appointments where doctor id matches 

            return Appointment.GetAppointmentsByDoctorId(DoctorId);
        }

        public static DataTable GetAppointmentsByPatient(string name)
        {           
            //return appointments where patient id matches
            return Appointment.GetAppointmentByPatientName(name);
        }

        /***********************************************************************
         *************** Functions Create/Update/Delete appointments ***********
         **********************************************************************/
        public static void InsertAppointmentRecord(Appointment apt)
        {
            DateTime formatSDate = apt.StartTime.ToUniversalTime();
            DateTime formatEDate = apt.EndTime.ToUniversalTime();
            var formatCreateDate = apt.CreateDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            var formatLastUpDate = apt.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");

            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                var insert_cmd = new MySqlCommand($"INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES({apt.CustomerId},{apt.UserId},'{apt.Title}','{apt.Description}','{apt.Location}','{apt.Contact}','{apt.Type}','{apt.URL}','{formatSDate.ToString("yyyy-MM-dd HH:mm:ss")}','{formatEDate.ToString("yyyy-MM-dd HH:mm:ss")}','{formatCreateDate}','{apt.CreatedBy}','{formatLastUpDate}','{apt.LastUpdateBy}')", DataAccess.conn);
                var insert = insert_cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DeleteAppointmentRecord(int aptId)
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

        public static void UpdateAppointmentRecord(Appointment apt)
        {
            DateTime formatSDate = apt.StartTime.ToUniversalTime();
            DateTime formatEDate = apt.EndTime.ToUniversalTime();
            var formatCreateDate = apt.CreateDate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            var formatLastUpDate = apt.LastUpdate.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            var now = DateTime.Now;

            if (DataAccess.conn.State is ConnectionState.Closed)
            {
                DataAccess.OpenConnection();
            }
            try
            {
                var update_cmd = new MySqlCommand($"UPDATE client_schedule.appointment SET appointment.customerId = {apt.CustomerId}, userId = {apt.UserId}, appointment.title = '{apt.Title}', appointment.description= '{apt.Description}', appointment.contact = '{apt.Contact}', appointment.type = '{apt.Type}', appointment.start = '{formatSDate.ToString("yyyy-MM-dd HH:mm:ss")}', appointment.end = '{formatEDate.ToString("yyyy-MM-dd HH:mm:ss")}',appointment.createDate= '{formatCreateDate}', appointment.lastUpdate = '{formatLastUpDate}' WHERE appointment.appointmentId = {apt.AppointmentId}; ", DataAccess.conn);
                var update = update_cmd.ExecuteNonQuery();
                DataAccess.CloseConnection();

            }
            catch (MySqlException exsql)
            {
                MessageBox.Show(exsql.Message);
            }


            MessageBox.Show(
                apt.CustomerName + "\n" +
                apt.UserId + "\n" +
                apt.Contact + "\n" +
                apt.Title + "\n" +
                apt.Type + "\n" +
                apt.Description + "\n" +
                apt.CreateDate + "\n" +
                apt.StartTime + " - local\n" +
                apt.StartTime.ToUniversalTime() + "- UTC \n" +
                apt.EndTime + "\n" +
                apt.Location + "\n" +
                apt.URL + "\n"
                );

        }
        //Test overlapping for NEW appointments. WORKS!!!
        public static bool IsAppointmentOverlapping(int userId, DateTime newAptStart, DateTime newAptEnd)
        {
            bool isOverlapping = false;
            DataTable allAppointments = GetAppointments();
            //Filter appointments by userId
            var usersAppointments = from usr in allAppointments.AsEnumerable()
                                    where usr.Field<int>("Doctor") == userId
                                    select new
                                    {
                                        appointmentId = usr.Field<int>("appointmentId"),
                                        userID = usr.Field<int>("Doctor"),
                                        startTime = usr.Field<DateTime>("start").ToLocalTime(),
                                        endTime = usr.Field<DateTime>("end").ToLocalTime(),
                                    };
            //Iterate over each user's appointments, and if the new appointment start time falls inbetween another appointment's time slot,
            //then 'isOverlapping' is true.
            foreach (var item in usersAppointments)
            {

                var start24 = newAptStart.ToString("yyyy-MM-dd HH:mm:ss");
                var end24 = newAptEnd.ToString("yyyy-MM-dd HH:mm:ss");
                var itemStart24 = item.startTime.ToString("yyyy-MM-dd HH:mm:ss");
                var itemEnd24 = item.endTime.ToString("yyyy-MM-dd HH:mm:ss");


                if (item.userID == userId)
                {                                       //new start falls between                                              new end falls between
                    if (DateTime.Parse(start24) >= DateTime.Parse(itemStart24) && DateTime.Parse(start24) <= DateTime.Parse(itemEnd24) || DateTime.Parse(end24) >= DateTime.Parse(itemStart24) && DateTime.Parse(end24) <= DateTime.Parse(itemEnd24))
                    {
                        isOverlapping = true;
                        return isOverlapping;

                    }
                    else if (DateTime.Parse(start24) <= DateTime.Parse(itemStart24) && DateTime.Parse(end24) >= DateTime.Parse(itemEnd24))
                    {
                        isOverlapping = true;
                        return isOverlapping;
                    }
                }


            }

            return isOverlapping;

        }

        public static bool IsModAppointmentOverlapping(Appointment current, int userId, DateTime newAptStart, DateTime newAptEnd)
        {
            bool isOverlapping = false;
            DataTable allAppointments = GetAppointments();

            //Filter appointments by userId
            var usersAppointments = from usr in allAppointments.AsEnumerable()
                                    where usr.Field<int>("Doctor") == userId
                                    select new
                                    {
                                        appointmentId = usr.Field<int>("appointmentId"),
                                        userID = usr.Field<int>("Doctor"),
                                        startTime = usr.Field<DateTime>("start").ToLocalTime(),
                                        endTime = usr.Field<DateTime>("end").ToLocalTime(),
                                    };


            foreach (var item in usersAppointments)
            {

                var start24 = newAptStart.ToString("yyyy-MM-dd HH:mm:ss");
                var end24 = newAptEnd.ToString("yyyy-MM-dd HH:mm:ss");
                var itemStart24 = item.startTime.ToString("yyyy-MM-dd HH:mm:ss");
                var itemEnd24 = item.endTime.ToString("yyyy-MM-dd HH:mm:ss");


                if (item.userID == userId && current.AppointmentId != item.appointmentId)
                {

                    //new start falls between                                              new end falls between
                    if (DateTime.Parse(start24) >= DateTime.Parse(itemStart24) && DateTime.Parse(start24) <= DateTime.Parse(itemEnd24) || DateTime.Parse(end24) >= DateTime.Parse(itemStart24) && DateTime.Parse(end24) <= DateTime.Parse(itemEnd24))
                    {
                        isOverlapping = true;
                        return isOverlapping;

                    }
                    else if (DateTime.Parse(start24) <= DateTime.Parse(itemStart24) && DateTime.Parse(end24) >= DateTime.Parse(itemEnd24))
                    {
                        isOverlapping = true;
                        return isOverlapping;
                    }
                }


            }
            return isOverlapping;
        }


    }
}
