using CustomExceptions.Entities.Exceptions;

namespace CustomExceptions.Entities;

public class Reservation
{
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public Reservation() { }

    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    {
        ValidateReservation(checkIn, checkOut);

        RoomNumber = roomNumber;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public int Duration()
    {
        TimeSpan duration = CheckOut - CheckIn;
        double totalDays = Math.Ceiling(duration.TotalDays);
        return (int)totalDays;
    }

    public void UpdateDates(DateTime checkIn, DateTime checkOut)
    {
        ValidateReservation(checkIn, checkOut);

        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    private static void ValidateReservation(DateTime checkIn, DateTime checkOut)
    {
        DateTime now = DateTime.Now;

        if (checkIn < now || checkOut < now)
            throw new ReservationException("Reservation date must be in future");
        if (checkOut <= checkIn)
            throw new ReservationException("Check-out date must be after Check-in date");

    }

    public override string ToString() => "{\n  \"roomNumber\": " + RoomNumber +
    ",\n  \"checkIn\": \"" + CheckIn +
    "\",\n  \"checkOut\": \"" + CheckOut +
    "\"\n}";
}
