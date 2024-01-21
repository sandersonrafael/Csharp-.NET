using System;

namespace TimeSpanProperties {
    class Program {
        static void Main(string[] args) {
            /* Properties */

            TimeSpan time = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine("time = new TimeSpan(2, 3, 5, 7, 11);");

            Console.WriteLine("\nStatic\n");

            Console.WriteLine($"TimeSpan.MaxValue: {TimeSpan.MaxValue}");
            Console.WriteLine($"TimeSpan.MinValue: {TimeSpan.MinValue}");
            Console.WriteLine($"TimeSpan.Zero: {TimeSpan.Zero}");

            Console.WriteLine("\nProperties\n");

            /* Common Properties */

            // Returns a integer value
            Console.WriteLine($"time.Days: {time.Days}");
            Console.WriteLine($"time.Hours: {time.Hours}");
            Console.WriteLine($"time.Minutes: {time.Minutes}");
            Console.WriteLine($"time.Milliseconds: {time.Milliseconds}");
            Console.WriteLine($"time.Microseconds: {time.Microseconds}");
            Console.WriteLine($"time.Nanoseconds: {time.Nanoseconds}");
            Console.WriteLine($"time.Seconds: {time.Seconds}");
            Console.WriteLine($"time.Ticks: {time.Ticks}\n");

            // Returns a exact value
            Console.WriteLine($"time.TotalDays: {time.TotalDays}");
            Console.WriteLine($"time.TotalHours: {time.TotalHours}");
            Console.WriteLine($"time.TotalMinutes: {time.TotalMinutes}");
            Console.WriteLine($"time.TotalSeconds: {time.TotalSeconds}");
            Console.WriteLine($"time.TotalMicroseconds: {time.TotalMicroseconds}");
            Console.WriteLine($"time.TotalMilliseconds: {time.TotalMilliseconds}");
            Console.WriteLine($"time.TotalNanoseconds: {time.TotalNanoseconds}");

            /* Operations */
            Console.WriteLine("\nOperations\n");

            TimeSpan time1 = new TimeSpan(1, 30, 10);
            TimeSpan time2 = new TimeSpan(0, 10, 5);
            Console.WriteLine($"time1 = TimeSpan(1, 30, 10)");
            Console.WriteLine($"time2 = TimeSpan(0, 10, 5)\n");

            Console.WriteLine($"time1.Add(time2): {time1.Add(time2)}");
            Console.WriteLine($"time1.Subtract(time2): {time1.Subtract(time2)}");
            Console.WriteLine($"time1.Multiply(2.0): {time1.Multiply(2.0)}");
            Console.WriteLine($"time1.Divide(2.0): {time1.Divide(2.0)}\n");
        }
    }
}
