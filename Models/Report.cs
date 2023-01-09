using AppointmentScheduler_C969.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        Dictionary<string, int> AptTypeCounts = new Dictionary< string, int>();
        private static string UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        private static string filePath = $@"c:\Users\{UserName.Split('\\')[1].ToString()}\Downloads\Reports\";


        public static void AppointmentTypesByMonth() { }    

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

        public static string ViewUserSchedule()
        {
            string schedule = "";
            string fileName = $@"{filePath}Consultant_Schedule.txt";
            DataTable dt = Appointment.GetAppoitments();
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
               
                while ( userCount >= i)
                {
                   var sorted = from appointments in dt.AsEnumerable()
                                 where appointments.Field<int>("Consultant") == i
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
    }
}
