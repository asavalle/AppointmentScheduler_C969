using System;

namespace AppointmentScheduler_C969.Models
{
    class Date
    {
        public static DateTime startTime = new DateTime();
        public static DateTime endTime = new DateTime();

        public TimeZoneInfo timeZone = TimeZoneInfo.Local;

        public static void BuildAppointmentDate(DateTime aDate, string start, string end)
        {

            //format selected Date value (aDate), parse to DateTime object, then convert to short date string
            var newAptDate = DateTime.Parse(aDate.ToString("yyyy-MM-dd hh:mm:ss")).ToShortDateString();
            string startT = start; //selected start time from combobox
            string endT = end; //selected end time from combobox

            //create a new Date string combining the formatted date with the time
            var startDateTime = newAptDate + " " + startT.ToString();
            var endDateTime = newAptDate + " " + endT.ToString();

            //Parse newly built date string to a DateTime object and convert to UTC before passing to DB
            startTime = DateTime.Parse(startDateTime);
            endTime = DateTime.Parse(endDateTime);
        }

        public static DateTime GetStartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = dt.DayOfWeek - startOfWeek;

            if (diff < 0)
            {
                diff += 7;
            }
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
