using CustomExceptions.Entities;
using CustomExceptions.Entities.Exceptions;

try
{
    Console.Write("Room number: ");
    int number = int.Parse(Console.ReadLine() ?? "0");

    Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine() ?? "invalid");

    Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine() ?? "invalid");

    Reservation reservation = new(number, checkIn, checkOut);
    Console.WriteLine(reservation);

    Console.WriteLine("\nEnter a new date to update reservation");

    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine() ?? "invalid");

    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine() ?? "invalid");

    reservation.UpdateDates(checkIn, checkOut);
}
catch (ReservationException e)
{
    Console.WriteLine($"Error: {e.Message}");
}
