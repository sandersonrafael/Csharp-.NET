using System;

namespace DateTimeProperties {
    class Program {
        static void Main(string[] args) {
            /* DateTime Properties */

            DateTime date = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine("new DateTime(2001, 8, 15, 13, 45, 58, 275):\n");

            Console.WriteLine("DateTime Properties\n");

            Console.WriteLine($"date.Date: {date.Date}");
            Console.WriteLine($"date.Day: {date.Day}");
            Console.WriteLine($"date.DayOfWeek: {date.DayOfWeek}");
            Console.WriteLine($"date.DayOfYear: {date.DayOfYear}");
            Console.WriteLine($"date.Hour: {date.Hour}");
            Console.WriteLine($"date.Kind: {date.Kind}");
            Console.WriteLine($"date.Milliseconds: {date.Millisecond}");
            Console.WriteLine($"date.Minute: {date.Minute}");
            Console.WriteLine($"date.Month: {date.Month}");
            Console.WriteLine($"date.Second: {date.Second}");
            Console.WriteLine($"date.Ticks: {date.Ticks}");
            Console.WriteLine($"date.TimeOfDay: {date.TimeOfDay}");
            Console.WriteLine($"date.Year: {date.Year}\n");

            /* Formatting */

            Console.WriteLine("Formatting\n");

            Console.WriteLine($"date.ToString(): {date}");
            Console.WriteLine($"date.ToLongDateString(): {date.ToLongDateString()}");
            Console.WriteLine($"date.ToLongTimeString(): {date.ToLongTimeString()}");
            Console.WriteLine($"date.ToShortDateString(): {date.ToShortDateString()}");
            Console.WriteLine($"date.ToShortTimeString(): {date.ToShortTimeString()}");
            Console.WriteLine($"date.ToString('yyyy-MM-dd HH:mm:ss'): {date:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"date.ToString('yyyy-MM-dd HH:mm:ss.fff'): {date:yyyy-MM-dd HH:mm:ss.fff}\n");

            /* Operations */

            Console.WriteLine("Add Operations\n");

            Console.WriteLine($"date: {date}\n");

            date = date.AddDays(3);
            Console.WriteLine($"date = date.AddDays(3): {date}");

            date = date.AddHours(3);
            Console.WriteLine($"date = date.AddHours(3): {date}");

            date = date.AddMicroseconds(3);
            Console.WriteLine($"date = date.AddMicroseconds(3): {date}");

            date = date.AddMilliseconds(3);
            Console.WriteLine($"date = date.AddMilliseconds(3): {date}");

            date = date.AddMinutes(3);
            Console.WriteLine($"date = date.AddMinutes(3): {date}");

            date = date.AddMonths(3);
            Console.WriteLine($"date = date.AddMonths(3): {date}");

            date = date.AddSeconds(3);
            Console.WriteLine($"date = date.AddSeconds(3): {date}");

            date = date.AddTicks(3);
            Console.WriteLine($"date = date.AddTicks(3): {date}");

            date = date.AddYears(1);
            Console.WriteLine($"date = date.AddYears(1): {date}\n");

            Console.WriteLine("Subtract Operation\n");
            TimeSpan time = new DateTime(2015, 12, 31).Subtract(new DateTime(2015, 12, 1));
            Console.WriteLine($"time = new DateTime(2015, 12, 31).Subtract(new DateTime(2015, 12, 1)): {time}\n");
        }
    }
}
