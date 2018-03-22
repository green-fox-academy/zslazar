using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalAp
{
    public class CalendarEventHandler
    {
        CalendarService service;

        public CalendarEventHandler(CalendarService service)
        {
            this.service = service;
        }

        public void CreateEvent(Event newEvent, string calendarId)
        {
            //String calendarId = "primary";
            EventsResource.InsertRequest request = service.Events.Insert(newEvent, calendarId);
            Event createdEvent = request.Execute();
            Console.WriteLine("Event created: {0}", createdEvent.HtmlLink);            
        }


        public void GetEvents(string calendarId)
        {
            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List(calendarId);
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 15;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            Console.WriteLine("Your upcoming events:");
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    string when = eventItem.Start.DateTime.ToString();
                    if (String.IsNullOrEmpty(when))
                    {
                        when = eventItem.Start.Date;
                    }
                    Console.WriteLine("{0} ({1})", eventItem.Summary, when);
                }
            }
            else
            {
                Console.WriteLine("No upcoming events found.");
            }
        }


        public void DeleteEvent(string calendarId, string eventId)
        {
            service.Events.Delete(calendarId, eventId).Execute();
        }


        public void UpdateEvent(Event newEvent, string calendarId, string eventId)
        {
            service.Events.Update(newEvent, calendarId, eventId).Execute();
        }


        public Event GenerateEvent()
        {
            return new Event()
            {
                Summary = "Mindfuck and learn",
                Location = "Andrássy út 66, Budapest, 1062",
                Description = "No chance.",
                Start = new EventDateTime()
                {
                    DateTime = DateTime.Parse("2018-03-22T19:00:00"),
                    TimeZone = "Europe/Budapest",
                },
                End = new EventDateTime()
                {
                    DateTime = DateTime.Parse("2018-03-22T20:00:00"),
                    TimeZone = "Europe/Budapest",
                },
                /*Recurrence = new String[] { "RRULE:FREQ=DAILY;COUNT=2" },
                Attendees = new EventAttendee[] {
                new EventAttendee() { Email = "lpage@example.com" },
                new EventAttendee() { Email = "sbrin@example.com" },
                },
                Reminders = new Event.RemindersData()
                {
                    UseDefault = false,
                    Overrides = new EventReminder[] {
                new EventReminder() { Method = "email", Minutes = 24 * 60 },
                new EventReminder() { Method = "sms", Minutes = 10 },
                }
                }*/
            };
        }


    }
}

