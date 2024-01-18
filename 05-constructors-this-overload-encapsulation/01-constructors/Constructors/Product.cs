namespace Constructors;

public class Product {

    public string? Name;
    public double Price;
    public int Quantity;

    public Product() {}

    public Product(string name, double price, int quantity) {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    // Overload (sobrecarga) -> Duas maneiras de utilizar o mesmo método ou construtor, com diferentes parametros / argumentos
    public Product(string name, double price) {
        Name = name;
        Price = price;
    }

    public void AddProducts(int quantity) {
        Quantity += quantity;
    }

    public void RemoveProducts(int quantity) {
        Quantity -= quantity;
    }

    public override string ToString() {
        return $"{"{\n"}  {'"'}name{'"'}: {'"'}{Name}{'"'},\n  {'"'}price{'"'}: {Price:F2},\n  {'"'}quantity{'"'}: {Quantity} {"\n}"}";
    }
}
