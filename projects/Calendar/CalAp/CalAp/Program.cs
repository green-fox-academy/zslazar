using CalAp;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalendarQuickstart
{
    class Program
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/calendar-dotnet-quickstart.json
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "Google Calendar API .NET Quickstart";

        static void Main(string[] args)
        {
            CalendarService service = InitializeCalendarService();
            //var calendarHandler = new CalendarHandler(service);
            var calendarEventHandler = new CalendarEventHandler(service);
            var calendarHandler = new CalendarHandler(service);

            //calendarEventHandler.GetEvents("primary");
            //calendarEventHandler.CreateEvent(calendarEventHandler.GenerateEvent(), "primary");
            //calendarEventHandler.DeleteEvent("primary", "f31umtjtvun4msldkmq8poacck");
            //calendarEventHandler.UpdateEvent(calendarEventHandler.GenerateEvent(), "primary", "no3m5085sv4ju67lqmbhu49tl0");

            //calendarHandler.CreateCalendar();
            //https://calendar.google.com/calendar/embed?src=9mfs64nfh4l3i1pq1sv1gajiho@group.calendar.google.com

            calendarHandler.DeleteCalendar("9mfs64nfh4l3i1pq1sv1gajiho@group.calendar.google.com");

            Console.ReadLine();
        }

        private static CalendarService InitializeCalendarService()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/calendar-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Calendar API service.
            return new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

    }  
}
