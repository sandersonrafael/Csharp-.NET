namespace CustomExceptions.Entities.Exceptions
{
    public class ReservationException : ApplicationException
    {
        public ReservationException(string message) : base(message) { }
    }
}
