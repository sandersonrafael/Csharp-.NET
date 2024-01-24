using System.Globalization;

namespace PredicateCs.Entities;

public class Product(string name, double price)
{
    public string Name { get; set; } = name;
    public double Price { get; set; } = price;

    public override string ToString() => $"{'{'} \"name\": \"{Name}\", \"price\": {FormattedPrice()} {'}'}";

    private string FormattedPrice() => Price.ToString("F2", CultureInfo.InvariantCulture);
}
