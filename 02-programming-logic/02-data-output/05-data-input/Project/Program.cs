using System;

namespace Project {
    internal class Program {
        static void Main(string[] args) {
            /* Entrada de Dados */

            // Utilizado para ler as entradas de usuário até a quebra de linha (enter)
            // Console.ReadLine();

            // Ex:
            System.Console.Write("Digite a frase desejada: ");
            string? phrase = Console.ReadLine();

            Console.WriteLine($"A frase digitada foi: {phrase}");

            Console.WriteLine("Agora digite 3 frutas");
            string? newPhrase = Console.ReadLine();
            string[] fruits = newPhrase != null ? newPhrase.Split(' ') : [];

            fruits.ToList().ForEach(fruit => Console.WriteLine(fruit));
        }
    }
}
