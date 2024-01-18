public class ProductCorretAutoProperties {
    // Pode ser adicionado o get e o set diretamente quando forem simples
    // Necessário declarar o atributo como public e setar conforme necessidade se get e set são private ou não
    // Snippets : prop | propg (com private set)

    private string _name;
    public double Price { get; private set; }
    public int Quantity { get; private set; }

    public ProductCorretAutoProperties() {}

    public ProductCorretAutoProperties(string name, double price, int quantity) {
        _name = name;
        Price = price;
        Quantity = quantity;
    }

    // Atribuindo o Get e o Set por meio de propriedades
    // A palavra value é uma palavra especial que significa o argumento do "método" Name
    public string Name {
        get { return _name; }
        set { if (value != null) _name = value; }
    }

    public double TotalValue() {
        return Price * Quantity;
    }

    public void AddProducts(int quantity) {
        Quantity += quantity;
    }

    public void RemoveProducts(int quantity) {
        Quantity -= quantity;
    }

    public override string ToString() {
        return $"{"{ "}name: {_name}, price: {Price}, quantity: {Quantity} {" }"}";
    }
}
