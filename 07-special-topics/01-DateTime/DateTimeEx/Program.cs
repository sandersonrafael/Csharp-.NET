/* DateTime */

// Returns the current system date and time
using System.Globalization;
using System.Runtime.Serialization;

DateTime d1 = DateTime.Now;
Console.WriteLine($"Now: {d1}");

// The saved time in C# language is in Ticks format, which represents 100 nanoseconds
Console.WriteLine($"Total ticks: {d1.Ticks}");
Console.WriteLine($"Milliseconds: {DateTime.Now.Ticks / 10000}");

/* DateTime Constructors */

// All constructors with hours can receive as an last argument a kind (from DateTimeKind enum), that
// determine if the hour is local or global

DateTime d2 = new DateTime(2023, 1, 31); // (year, month, date)
Console.WriteLine($"Constructor (year, month, date): {d2}");

d2 = new DateTime(2023, 2, 28, 1, 35, 45, DateTimeKind.Utc); // (year, month, date, hour, minute, second)
Console.WriteLine($"Constructor (year, month, date, hour, minute, second): {d2}");

d2 = new DateTime(2023, 2, 28, 1, 35, 45, 700, DateTimeKind.Local); // (year, month, date, hour, minute, second, milliseconds)
Console.WriteLine($"Constructor (year, month, date, hour, minute, second, milliseconds): {d2}");

/* DateTime Builders */

Console.WriteLine($"DateTime.Now: {DateTime.Now}");
Console.WriteLine($"DateTime.UtcNow: {DateTime.UtcNow}");
Console.WriteLine($"DateTime.Today: {DateTime.Today}");

Console.WriteLine($"DateTime.Parse('01/01/2023'): {DateTime.Parse("01/01/2023")}");
Console.WriteLine($"DateTime.Parse('01/01/2023 14:50:10'): {DateTime.Parse("01/01/2023 14:50:10")}");
Console.WriteLine($"DateTime.Parse('2024-01-20'): {DateTime.Parse("2024-01-20")}");
Console.WriteLine($"DateTime.Parse('2024-01-20 02:35:13'): {DateTime.Parse("2024-01-20 02:35:13")}");

Console.WriteLine($"DateTime.ParseExact('01/01/2023', 'dd/MM/yyyy', CultureInfo.InvariantCulture): {DateTime.ParseExact("01/01/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture)}");
Console.WriteLine($"DateTime.ParseExact('01/01/2023 15:30:16', 'dd/MM/yyyy HH:mm:ss', CultureInfo.InvariantCulture): {DateTime.ParseExact("01/01/2023 15:30:16", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
