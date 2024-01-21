using System;

namespace DateTImeKindEx;

class Program {
    static void Main(string[] args) {
        /* DateTimeKind */

        // Represents an Enum with 3 default values

        // Local -> Represents a time zone of the machine
        // Utc -> Represents a time zone GMT (Greenwich Mean Time)
        // Unspecified

        // It is recommended to always store date data in UTC format

        /* Conversion */

        // To convert a DateTime for Local -> date.ToLocalTime()
        // To convert a DateTime for Utc -> date.ToUniversalTime()

        DateTime date1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
        DateTime date2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
        DateTime date3 = new DateTime(2000, 8, 15, 13, 5, 58);

        // Don't have any difference in execution, because the compiler show's the date like the informed
        Console.WriteLine("\n" + date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3 + "\n");

        Console.WriteLine($"date1.Kind: {date1.Kind}\n");
        Console.WriteLine($"date1.ToLocalTime(): {date1.ToLocalTime()}");
        Console.WriteLine($"date1.ToUniversalTime(): {date1.ToUniversalTime()}\n");

        Console.WriteLine($"date2.Kind: {date2.Kind}\n");
        Console.WriteLine($"date2.ToLocalTime(): {date2.ToLocalTime()}");
        Console.WriteLine($"date2.ToUniversalTime(): {date2.ToUniversalTime()}\n");

        Console.WriteLine($"date3.Kind: {date3.Kind}\n");
        Console.WriteLine($"date3.ToLocalTime(): {date3.ToLocalTime()}");
        Console.WriteLine($"date3.ToUniversalTime(): {date3.ToUniversalTime()}\n");

        Console.WriteLine("\nDateTime.Now\n");
        Console.WriteLine($"DateTime.Now.ToLocalTime(): {DateTime.Now.ToLocalTime()}");
        Console.WriteLine($"DateTime.Now.ToUniversalTime(): {DateTime.Now.ToUniversalTime()}\n");

        /* ISO 8601 */

        // Format: yyyy-MM-ddTHH:mm:ssZ
        // Z -> represents that date/time is in Utc format

        DateTime date4 = DateTime.Parse("2000-08-15 13:05:58");
        DateTime date5 = DateTime.Parse("2000-08-15T13:05:58Z");

        Console.WriteLine("\n" + date4);
        Console.WriteLine(date5);
    }
}
