using System;

namespace Constructors;

class Program {

    static void Main(String[] args) {
        /* Especial implementation -> In C#, it's possible to define the object, passing the attributes values. Ex: */
        Product especialProduct = new Product {
            Name = "TV",
            Price = 499.99,
            Quantity = 3
        };
        Console.WriteLine(especialProduct);

        Console.WriteLine("Enter the product data: ");
        Console.Write("Name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine() ?? "0.0");

        Console.Write("Quantity: ");
        int quantity = int.Parse(Console.ReadLine() ?? "0");

        Product p = new Product(name, price, quantity);
        Console.WriteLine(p);

        Console.Write("Enter the number of products to be added in the stock: ");
        quantity = int.Parse(Console.ReadLine() ?? "0");
        p.AddProducts(quantity);
        Console.WriteLine("Total products in stock now: " + p.Quantity);

        Console.Write("Enter the number of products to be removed from the stock: ");
        quantity = int.Parse(Console.ReadLine() ?? "0");
        p.RemoveProducts(quantity);
        Console.WriteLine("Total products in stock now: " + p.Quantity);
    }
}
