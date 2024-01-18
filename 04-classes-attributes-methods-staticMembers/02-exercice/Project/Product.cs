namespace Project;

public class Product {

    public string? Name;
    public double Price;
    public int Quantity;

    public double TotalValue() {
        return Price * Quantity;
    }

    public override string ToString() {
        return $"Name: {Name}, Price: {Price:F2} and Quantity: {Quantity}";
    }
}
