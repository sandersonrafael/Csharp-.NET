using System;
using System.Globalization;

namespace Project {
    internal class Program {
        static void Main(String[] args) {
            Triangle x = new Triangle();
            Triangle y = new Triangle();

            Console.WriteLine("Insira as medidas do triângulo x: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Área do Triângulo x: {x.Area()}");

            Console.WriteLine("Insira as medidas do triângulo y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Área do Triângulo y: {y.Area()}");
        }
    }
}
