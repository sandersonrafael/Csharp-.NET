using System;

namespace TimeSpanEx {
    class Program {
        static void Main(string[] args) {
            /* TimeSpan */
            // Represents a duration | Stores duration in tick format as well

            /* Constructors */

            // new TimeSpan()
            // new TimeSpan(Ticks)
            // new TimeSpan(hours, minutes, seconds)
            // new TimeSpan(days, hours, minutes, seconds)
            // new TimeSpan(days, hours, minutes, seconds, milliseconds)

            Console.WriteLine($"new TimeSpan(): {new TimeSpan()}");
            Console.WriteLine($"new TimeSpan(90000000L): {new TimeSpan(90000000L)}");

            TimeSpan timeHHmmss = new TimeSpan(0, 5, 13);
            Console.WriteLine($"new TimeSpan(0, 5, 13): {timeHHmmss} / Ticks: {timeHHmmss.Ticks}");

            TimeSpan timeddHHmmss = new TimeSpan(1, 0, 5, 13);
            Console.WriteLine($"new TimeSpan(1, 0, 5, 13): {timeddHHmmss} / Ticks: {timeddHHmmss.Ticks}");

            TimeSpan timeddHHmmssMl = new TimeSpan(1, 0, 5, 13, 300);
            Console.WriteLine($"new TimeSpan(1, 0, 5, 13, 300): {timeddHHmmssMl} / Ticks: {timeddHHmmssMl.Ticks}\n");

            /* "From" methods */

            // TimeSpan.FromDays;
            // TimeSpan.FromHours;
            // TimeSpan.FromMicroseconds;
            // TimeSpan.FromMilliseconds;
            // TimeSpan.FromMinutes;
            // TimeSpan.FromSeconds;
            // TimeSpan.FromTicks;

            TimeSpan t1 = TimeSpan.FromDays(1.5);
            Console.WriteLine($"TimeSpan.FromDays(1.5): {t1} / Ticks: {t1.Ticks}");

            TimeSpan t2 = TimeSpan.FromHours(1.5);
            Console.WriteLine($"TimeSpan.FromHours(1.5): {t2} / Ticks: {t2.Ticks}");

            TimeSpan t3 = TimeSpan.FromMicroseconds(1.5);
            Console.WriteLine($"TimeSpan.FromMicroseconds(1.5): {t3} / Ticks: {t3.Ticks}");

            TimeSpan t4 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine($"TimeSpan.FromMilliseconds(1.5): {t4} / Ticks: {t4.Ticks}");

            TimeSpan t5 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine($"TimeSpan.FromMinutes(1.5): {t5} / Ticks: {t5.Ticks}");

            TimeSpan t6 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine($"TimeSpan.FromSeconds(1.5): {t6} / Ticks: {t6.Ticks}");

            TimeSpan t7 = TimeSpan.FromTicks(150000000L);
            Console.WriteLine($"TimeSpan.FromTicks(150000000): {t7} / Ticks: {t7.Ticks}\n");

        }
    }
}
