using System.Globalization;
using Composition.Entities;
using Composition.Entities.Enums;

/* Exercise */

Console.Write("Enter department's name: ");
string department = Console.ReadLine() ?? "";

Console.Write("Enter worker name: ");
string name = Console.ReadLine() ?? "";

Console.Write("Enter worker's Level (JUNIOR / MID_LEVEL / SENIOR): ");
string level = Console.ReadLine() ?? "JUNIOR";

Console.Write("Enter worker's base salary: ");
double salary = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);

Console.Write("How Many Contracts to this worker?: ");
int contracts = int.Parse(Console.ReadLine() ?? "0");

Worker worker = new(name, Enum.Parse<WorkerLevel>(level), salary, new Department(department));

for (int i = 1; i <= contracts; i++)
{
    Console.Write($"\n## Contract {i} ##\n");

    Console.Write("Date (dd/MM/yyyy): ");
    DateTime date = DateTime.Parse(Console.ReadLine() ?? "01/01/2001");

    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);

    Console.Write("Duration (hours): ");
    int duration = int.Parse(Console.ReadLine() ?? "0");

    worker.AddContract(new HourContract(date, valuePerHour, duration));
}

Console.Write("\nEnter the month and year to calculate income (MM/yyyy): ");
string[] monthYear = (Console.ReadLine() ?? "01/2001").Split("/");
int month = int.Parse(monthYear[0]);
int year = int.Parse(monthYear[1]);

Console.WriteLine($"Name: {worker.Name}");
Console.WriteLine($"Department: {worker.Department?.Name}");
Console.WriteLine($"Income for {monthYear[0]}/{year}: {worker.Income(year, month)}");
