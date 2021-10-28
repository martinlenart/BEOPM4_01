using System;

namespace BEOPM4_01_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get local TimeZone
            Console.WriteLine(TimeZoneInfo.Local.StandardName);
            Console.WriteLine(TimeZoneInfo.Local.BaseUtcOffset);

            //Set a specific TimeZone
            TimeZoneInfo wa = TimeZoneInfo.FindSystemTimeZoneById("W. Australia Standard Time");
            Console.WriteLine();
            Console.WriteLine(wa.Id);                   // W. Australia Standard Time
            Console.WriteLine(wa.DisplayName);          // (GMT+08:00) Perth
            Console.WriteLine(wa.BaseUtcOffset);        // 08:00:00
            Console.WriteLine(wa.SupportsDaylightSavingTime);     // True
            Console.WriteLine();

            // The following returns all world timezones:
            foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
                Console.WriteLine(z.Id);

            //Daylight savings time
            Console.WriteLine();
            Console.WriteLine(TimeZoneInfo.Local.SupportsDaylightSavingTime);   //True
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());             //True or False

            foreach (TimeZoneInfo.AdjustmentRule rule in TimeZoneInfo.Local.GetAdjustmentRules())
            {
                Console.WriteLine();
                Console.WriteLine($"Rule: Hour: {rule.DaylightDelta} " +
                    $"\n   starts {rule.DaylightTransitionStart.DayOfWeek} " +
                    $"Week: {rule.DaylightTransitionStart.Week} in Month:{rule.DaylightTransitionStart.Month}" +
                    $"\n   ends {rule.DaylightTransitionEnd.DayOfWeek} " +
                    $"Week: {rule.DaylightTransitionEnd.Week} in Month:{rule.DaylightTransitionEnd.Month}");
            }
        }
    }
}
