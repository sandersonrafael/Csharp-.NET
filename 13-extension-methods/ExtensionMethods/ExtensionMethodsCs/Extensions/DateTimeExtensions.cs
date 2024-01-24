using System.Globalization;

namespace ExtensionMethodsCs.Extensions;

/* To create a extension method, the class must be static */
public static class DateTimeExtensions
{
    // It is necessary to add has first argument the extended Class (here is DateTime)
    public static string ElapsedTime(this DateTime thisObj)
    {
        TimeSpan duration = DateTime.Now - thisObj;
        double hours = duration.TotalHours;
        double days = duration.TotalDays;

        return hours < 24.0
            ? hours.ToString("F1", CultureInfo.InvariantCulture)
            : days.ToString("F1", CultureInfo.InvariantCulture);
    }
}
