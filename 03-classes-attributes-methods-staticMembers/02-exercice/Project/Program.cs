using System;
using System.Globalization;

namespace Project {
    internal class Program {
        static void Main(String[] args) {

            Product p = new Product();

            Console.WriteLine("Informe os dados do produto...");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();

            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Quantidade: ");
            p.Quantity = int.Parse(Console.ReadLine() ?? "0");

            // Console.WriteLine($"Name: {p.Name}, price: {p.Price} and quantity: {p.Quantity}");
            Console.WriteLine(p);
            Console.WriteLine($"Total value: {p.TotalValue()}");

        }
    }
}
