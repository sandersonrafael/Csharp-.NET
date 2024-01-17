using System;
using System.Globalization;

namespace PCI {
    internal class Program {
        static void Main(String[] args) {
            int age = 32;
            double salary = 2549.975;
            string name = "Mariana";

            /* Placeholders */

            // Para utilizar os placeholders, basta utilizar {n} na sequência das variáveis que serão informadas
            // É possível formatar com o :Fn. Ex: {2:F2}
            System.Console.WriteLine("{0} have {1} years and his salary is {2:F2}", name, age, salary);

            /* Interpolation */

            // Similar ao `${variavel}` do JavaScript. Mas faz-se com $"{variavel} ...text... {variavel2} ...etc..."
            // Também é possível formatar com :Fn ->
            System.Console.WriteLine($"{name} have {age} years and his salary is {salary:F2}");

            /* Concatenation */
            System.Console.WriteLine(name + " have " + age + " years and his salary is " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
