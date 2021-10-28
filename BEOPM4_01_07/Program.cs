using System;
using System.Globalization;

namespace BEOPM4_01_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructing TimeSpan
            Console.WriteLine(new TimeSpan(10, 2, 15, 0));  // 10days, 2h, 15m, 10s
            Console.WriteLine(TimeSpan.FromHours(2.5));     // 02:30:00
            Console.WriteLine(DateTime.Today - DateTime.Parse("2021-01-01")); // Days from New Year

            //Using TimeSpan
            Console.WriteLine();
            Console.WriteLine(TimeSpan.FromHours(2) - TimeSpan.FromMinutes(160)); // -40 minutes
            Console.WriteLine(TimeSpan.FromDays(30) - TimeSpan.FromSeconds(90));  // 29.23:58:30

            //Constructing DateTime and DateTimeOffset
            DateTime d1 = new DateTime(2021, 1, 1, 12, 0, 0);      // Midday, January 30 2010
            Console.WriteLine();
            Console.WriteLine(d1);
            Console.WriteLine(d1.Kind);

            DateTime d2 = new DateTime(2021, 1, 1, 12, 0, 0, DateTimeKind.Utc);
            Console.WriteLine();
            Console.WriteLine(d2);
            Console.WriteLine(d2.Kind);

            DateTimeOffset d3 = new DateTimeOffset(d1, TimeSpan.FromHours(-8)); // -8 hours UTC
            Console.WriteLine();
            Console.WriteLine(d3);
            Console.WriteLine(d3.ToUniversalTime());

            Console.WriteLine();
            Console.WriteLine(DateTimeOffset.Now);
            Console.WriteLine(DateTimeOffset.Now.ToUniversalTime());

            //Comparing DateTime and DateTimeOffset
            DateTime d4 = new DateTime(2021, 1, 1, 12, 35, 0);
            DateTime d5 = new DateTime(2021, 1, 1, 12, 35, 0);
            Console.WriteLine(); 
            Console.WriteLine(d4 == d5);                        //True as local times equal

            DateTimeOffset d6 = new DateTimeOffset(2020, 12, 31, 20, 35, 0, TimeSpan.FromHours(-8)); // -8 hours UTC
            DateTimeOffset d7 = new DateTimeOffset(2021, 1, 1, 12, 35, 0, TimeSpan.FromHours(8)); // 8 hours UTC
            Console.WriteLine(d6 == d7);                        //True as same point in time (UTC)


            //Working with calendars
            //Gregorian (our) to Japanese
            var jpCal = new JapaneseCalendar();
            int year = jpCal.GetYear(DateTime.Today);
            int month = jpCal.GetMonth(DateTime.Today);
            int day = jpCal.GetDayOfMonth(DateTime.Today);
            Console.WriteLine();
            Console.WriteLine($"{DateTime.Today:d} in Gregorian calendar is {year}-{month}-{day} in Japanese calendar");

            //Japanese to Gregorian (our)
            DateTime nextyear = new DateTime(year, month, day, jpCal);
            Console.WriteLine($"{year+1}-{month}-{year} in Japanese calendar is {nextyear:d} in Gregiorian calendar");
        }
    }
}
