namespace CustomEqualsGetHashCode.Entities;

public class Customer(string? name, string email)
{
    public string? Name { get; set; } = name;
    public string? Email { get; set; } = email;

    public override bool Equals(object? obj)
    {
        if (obj is not Customer) return false;

        Customer other = (Customer)obj;
        if (Email == other.Email) return true;

        return false;
    }

    public override int GetHashCode()
    {
        return Email?.GetHashCode() ?? throw new NullReferenceException();
    }
}
