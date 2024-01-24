using System.Globalization;

namespace IComparableExample.Entities;

public class Employee(string? name, double salary) : IComparable
{
    public string? Name { get; set; } = name;
    public double Salary { get; set; } = salary;

    public override string ToString() => Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);

    public int CompareTo(object? obj)
    {
        if (obj is not Employee) throw new ArgumentException("Invalid param");

        Employee other = (Employee)obj;
        return Salary.CompareTo(other.Salary);
    }
}
