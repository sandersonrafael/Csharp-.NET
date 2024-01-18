namespace Constructors;

public class Product {

    public string Name;
    public double Price;
    public int Quantity;

    public Product() {
        Quantity = 0;
    }

    // O this pode ser usado para atribuir outro construtor a um novo construtor, com a notação : this()
    public Product(string name, double price) : this() {
        Name = name;
        Price = price;
    }

    // Também pode ser chamado o this para um construtor que recebe argumentos
    // pode ser do novo construtor ou argumentos literais ("Fulano", 350, etc)
    public Product(string name, double price, int quantity) : this(name, price) {
        Quantity = quantity;
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
