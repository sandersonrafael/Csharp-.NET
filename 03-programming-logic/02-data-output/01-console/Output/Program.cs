using System;
using System.Globalization;

namespace Output {
    class Program {
        static void Main(String[] args) {
            /* Quebra de linha */

            System.Console.Write("Bom dia!"); // Escreve somente inline
            System.Console.WriteLine("Boa tarde!"); // Escreve com quebra de linha
            System.Console.WriteLine("Boa noite!\n"); // \n para quebra de linha adicional

            /* Imprimindo variáveis */

            char gender = 'F';
            int age = 32;
            string name = "Maria";
            double salary = 1320.4974D;

            System.Console.WriteLine(gender);
            System.Console.WriteLine(age);
            System.Console.WriteLine(name);

            // Para delimitar casas, usar o método ToString("Fn") -> n é o número de casas
            System.Console.WriteLine(salary.ToString("F2"));

            // Para formatar, é necessário adicionar o segundo argumento ao método ToString() que é um IFormatProvider
            // Para tal, é necessário adicionar -> using System.Globalization;
            System.Console.WriteLine(salary.ToString("F4", CultureInfo.InvariantCulture)); // padrão americano, com . em vez de ,
        }
    }
}
