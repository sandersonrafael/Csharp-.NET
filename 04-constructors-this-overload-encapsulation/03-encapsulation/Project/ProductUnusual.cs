namespace Project;

/* Implementação manual com Get e Set (não usual) */
public class ProductUnusual {

    private string _name;
    private double _price;
    private int _quantity;

    public ProductUnusual() {}

    public ProductUnusual(string name, double price, int quantity) {
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public string GetName() {
        return _name;
    }

    public void SetName(string name) {
        _name = name;
    }

    public double GetPrice() {
        return _price;
    }

    public int GetQuantity() {
        return _quantity;
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
