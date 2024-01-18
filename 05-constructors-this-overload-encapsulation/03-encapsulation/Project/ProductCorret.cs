public class ProductCorret {

    private string _name;
    private double _price;
    private int _quantity;

    public ProductCorret() {}

    public ProductCorret(string name, double price, int quantity) {
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    // Atribuindo o Get e o Set por meio de propriedades
    // A palavra value é uma palavra especial que significa o argumento do "método" Name
    public string Name {
        get { return _name; }
        set { if (value != null) _name = value; }
    }

    public double Price {
        get { return _price; }
    }

    public int Quantity {
        get { return _quantity; }
    }

    public double TotalValue() {
        return _price * _quantity;
    }

    public void AddProducts(int quantity) {
        _quantity += quantity;
    }

    public void RemoveProducts(int quantity) {
        _quantity -= quantity;
    }

    public override string ToString() {
        return $"{"{ "}name: {_name}, price: {_price}, quantity: {_quantity} {" }"}";
    }
}
