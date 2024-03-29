﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace AppointmentScheduler_C969.Models
{
    class Report
    {
        enum Month
        {
            January,    //0
            Febuary,    //1
            March,      //2
            April,      //3
            May,        //4
            June,       //5
            July,       //6
            August,     //7
            September,  //8
            October,    //9
            November,   //10
            December    //11
        }


        Dictionary<string, Object> months = new Dictionary<string, object>();
        Dictionary<string, int> AptTypeCounts = new Dictionary<string, int>();
        private static string UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        private static string filePath = $@"c:\Users\{UserName.Split('\\')[1].ToString()}\Downloads\Reports\";


        public static string AppointmentTypesByMonth(int month, string type)
        {
            string schedule = "";
            string fileName = $@"{filePath}Appointments_By_Month_Type.txt";
            DataTable at = Appointment.GetAppointments();



            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            var sorted = from apts in at.AsEnumerable()
                         where apts.Field<DateTime>("start").Month == month
                         where apts.Field<string>("type") == type
                         select new
                         {
                             AppointmentId = apts.Field<int>("appointmentId"),
                             CustomerName = apts.Field<string>("customerName"),
                             Title = apts.Field<string>("title"),
                             Type = apts.Field<string>("type"),
                             StartTime = apts.Field<DateTime>("start"),
                             AptDate = apts.Field<DateTime>("appointment_Date")
                         };
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine("==================================================");
                sw.WriteLine($"Schedule for '{Appointment.Months.GetValueOrDefault(month)}' and '{type}':\n");
                sw.WriteLine("==================================================");

                foreach (var item in sorted)
                {

                    sw.WriteLine(item);


                }
                sw.Close();
            }
            schedule = File.ReadAllText(fileName);


            return schedule;
        }

        public static void LoginLogReport()
        {
            string fileName = $@"{filePath}login.txt";
            string file = "";
            //If directory doesn't exist, create 'Reports' directory and save login.txt inside
            if (!File.Exists(fileName))
            {
                (new FileInfo(fileName)).Directory.Create(); //create directory if not existing
                using (StreamWriter fileSW = File.AppendText(fileName))
                {
                    fileSW.WriteLine($"User {DataAccess.LoggedInUser} logged in on {DateTime.Now}");
                    fileSW.Close();

                }
            }
            else //If directory does exist, then append to 'login.txt'.
            {

                //Read in entire file.
                StreamReader sr = new StreamReader(fileName);

                file = sr.ReadToEnd();
                sr.Close();

                //Add new line, Then write read file to existing file
                StreamWriter fileSW = new StreamWriter(fileName);


                fileSW.WriteLine($"User {DataAccess.LoggedInUser} logged in on {DateTime.Now}");
                fileSW.Write(file);
                fileSW.Close();


            }

        }
        public static void FailedLoginLogReport(string name)
        {
            string fileName = $@"{filePath}login.txt";
            string file = "";
            //If directory doesn't exist, create 'Reports' directory and save login.txt inside
            if (!File.Exists(fileName))
            {
                (new FileInfo(fileName)).Directory.Create(); //create directory if not existing
                using (StreamWriter fileSW = File.AppendText(fileName))
                {
                    fileSW.WriteLine($"User {name} failed to log in on {DateTime.Now}. ");
                    fileSW.Close();

                }
            }
            else //If directory does exist, then append to 'login.txt'.
            {

                //Read in entire file.
                StreamReader sr = new StreamReader(fileName);

                file = sr.ReadToEnd();
                sr.Close();

                //Add new line, Then write read file to existing file
                StreamWriter fileSW = new StreamWriter(fileName);


                fileSW.WriteLine($"User {name} failed to log in on {DateTime.Now}. ");
                fileSW.Write(file);
                fileSW.Close();


            }

        }
        public static string ViewUserSchedule()
        {
            string schedule = "";
            string fileName = $@"{filePath}Doctor_Schedule.txt";
            DataTable dt = Appointment.GetAppointments();
            DataTable ut = User.GetUsers();

            var numUsers = from user in ut.AsEnumerable()
                           group user by user["userId"] into count
                           select count;
            int i = 1;
            int userCount = numUsers.ToList().Count;
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }



            foreach (DataRow r in dt.Rows)
            {

                while (userCount >= i)
                {
                    var sorted = from appointments in dt.AsEnumerable()
                                 where appointments.Field<int>("Doctor") == i
                                 orderby appointments.Field<int>("appointmentId") ascending
                                 select new
                                 {
                                     AppointmentId = appointments.Field<int>("appointmentId"),
                                     CustomerName = appointments.Field<string>("customerName"),
                                     Title = appointments.Field<string>("title"),
                                     StartTime = appointments.Field<DateTime>("start"),
                                     AptDate = appointments.Field<DateTime>("appointment_Date")
                                 };


                    using (StreamWriter sw = File.AppendText(fileName))
                    {
                        sw.WriteLine("==================================================");
                        sw.WriteLine($"Schedule for User '{User.GetUserNameById(i)}':\n");
                        sw.WriteLine("==================================================");

                        foreach (var item in sorted)
                        {

                            sw.WriteLine(item);


                        }
                        sw.Close();
                    }


                    i++;
                }


            }



            schedule = File.ReadAllText(fileName);


            return schedule;


        }
        public static string ViewUserSchedule(string name)
        {
            string schedule = "";
            string fileName = $@"{filePath}Doctor_Schedule.txt";
            DataTable dt = Appointment.GetAppointments();
            DataTable ut = User.GetUsers();

            var numUsers = from user in ut.AsEnumerable()
                           group user by user["userId"] into count
                           select count;
            int i = 1;
            int userCount = numUsers.ToList().Count;
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }


            var sorted = from appointments in dt.AsEnumerable()
                         where appointments.Field<int>("Doctor") == User.GetUserIDbyName(name)
                         orderby appointments.Field<int>("appointmentId") ascending
                         select new
                         {
                             AppointmentId = appointments.Field<int>("appointmentId"),
                             CustomerName = appointments.Field<string>("customerName"),
                             Title = appointments.Field<string>("title"),
                             StartTime = appointments.Field<DateTime>("start"),
                             AptDate = appointments.Field<DateTime>("appointment_Date")
                         };


            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine("==================================================");
                sw.WriteLine($"Schedule for User '{name}':\n");
                sw.WriteLine("==================================================");

                foreach (var item in sorted)
                {

                    sw.WriteLine(item);


                }
                sw.Close();
            }


            schedule = File.ReadAllText(fileName);


            return schedule;


        }

        public static string ViewLoginReport()
        {
            string fileName = $@"{filePath}login.txt";
            string log = "";

            if (File.Exists(fileName))
            {
                log = File.ReadAllText(fileName);
                return log;
            }
            return log;
        }

        public static string ViewAppointmentsByCustomer(string custName)
        {
            string report = "";
            string fileName = $@"{filePath}AppointmentsByCustomer_Report.txt";
            DataTable ct = Customer.GetCustomers();
            DataTable at = Appointment.GetAppointments();


            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }


            var sorted = from apt in at.AsEnumerable()
                         where apt.Field<string>("customerName") == custName
                         orderby apt.Field<int>("appointmentId") ascending
                         select new
                         {
                             AppointmentId = apt.Field<int>("appointmentId"),
                             CustomerName = apt.Field<string>("customerName"),
                             Title = apt.Field<string>("title"),
                             StartTime = apt.Field<DateTime>("start"),
                             AptDate = apt.Field<DateTime>("appointment_Date")
                         };


            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine("==================================================");
                sw.WriteLine($"Appointments for '{custName}':\n");
                sw.WriteLine("==================================================");

                foreach (var item in sorted)
                {

                    sw.WriteLine(item);

                }
                sw.Close();
            }


            report = File.ReadAllText(fileName);


            return report;

        }
    }
}
