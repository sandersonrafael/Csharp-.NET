namespace LinqExample.Entities;

public class Product(int id, string name, double price, Category category) : IComparable
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public double Price { get; set; } = price;

    public Category Category { get; set; } = category;

    public int CompareTo(object? obj)
    {
        if (obj is not Product) throw new ArgumentException("Invalid object");
        Product other = (Product)obj;
        return Price.CompareTo(other.Price);
    }

    public override string ToString() => $"{'{'} \"id\": {Id}, \"name\": \"{Name}\", \"price\": {Price:F2}, \"category\": {Category} {'}'}";
}
