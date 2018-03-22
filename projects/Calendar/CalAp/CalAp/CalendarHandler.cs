using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalAp
{
    class CalendarHandler
    {
        CalendarService service;

        public CalendarHandler(CalendarService service)
        {
            this.service = service;
        }

        public void CreateCalendar()
        {
            Calendar calendar = new Calendar();
            calendar.Description = "applicationName";
            calendar.Summary = "Calendula";
            calendar.TimeZone = "America/Los_Angeles";

            Calendar createdCalendar = service.Calendars.Insert(calendar).Execute();
            Console.WriteLine(createdCalendar.Id);
        }

        public void DeleteCalendar(string calendarId)
        {
            service.Calendars.Delete(calendarId).Execute();
        }
    }
}
