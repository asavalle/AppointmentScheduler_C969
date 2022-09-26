using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentScheduler_C969.Models
{
    class Date
    {
        public static DateTime startTime = new DateTime();
        public static DateTime endTime = new DateTime();

        public static void BuildAppointmentDate(DateTime aDate, string start, string end)
        {
            /*Creates a new DateTime object, assigns it the value from the DateTimePicker control. Then it takes that new object and assigns
             * it to the aptData variable and applies the ToShortDateString method to grab only the date portion. 
             * After that, the Start and End times are retrieved from the appropriate combobox and then appeneded to the aptData to create a complete
             * start and end date/time variable. Lastly, those variables are parsed into new DateTime objects.
             */
            DateTime date = new DateTime();

            date = aDate;
            var aptData = date.ToShortDateString();
            string startT = start;
            string endT = end;
            var startDateTime = aptData + " " + startT.ToString();
            var endDateTime = aptData + " " + endT.ToString();
            startTime = DateTime.Parse(startDateTime);
            endTime = DateTime.Parse(endDateTime);
        }

        public static DateTime GetStartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = dt.DayOfWeek - startOfWeek;

            if(diff < 0)
            {
                diff += 7;
            }
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
