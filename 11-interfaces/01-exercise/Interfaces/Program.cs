using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;

Console.WriteLine("Enter rental data");

Console.Write("Car model: ");
string? model = Console.ReadLine();

Console.Write("Pickup date:hour (dd/MM/yyyy HH:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine() ?? "", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Return date:hour (dd/MM/yyyy HH:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine() ?? "", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Enter price per hour: ");
double pricePerHour = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);

Console.Write("Enter price per day: ");
double pricePerDay = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);

CarRental carRental = new(start, finish, new Vehicle(model));

RentalService rentalService = new(pricePerHour, pricePerDay, new BrazilTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine("Invoice: ");
Console.WriteLine(carRental.Invoice);
