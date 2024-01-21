using System;

namespace Project {
    internal class Program {
        static void Main(string[] args) {
            /* Implicit type conversion */
            float x = 4.5F;
            double y = x; // nesse caso, a conversão é possível e implícita, pois o double suporta valores float

            // não funciona implicitamente, pois nem todo valor double é suportado por um float
            // Necessário adicionar conversão explícita (casting) do formato: (tipo) variavel. Ex:
            double a = 5.1;
            float b = (float) a;

            // Tipos que não são totalmente compatíveis, pode haver perda de valor. Ex:
            double d = 5.1;
            int e = (int) d; // retornará 5

            // Casos de atenção:
            int f = 5;
            int g = 2;
            // resultará em 2 se não for feito casting, pois o C# entende que o resultado é int
            double h = (double) f / g;
            System.Console.WriteLine(h);

            // Objeto Math
            double quad = Math.Pow(3, 3);
            System.Console.WriteLine(quad);

            double root = Math.Sqrt(16.0);
            System.Console.WriteLine(root);
        }
    }
}
