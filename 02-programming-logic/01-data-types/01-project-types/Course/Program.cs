using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            /*
            SByte x = 100; // no C# o tipo é o sbyte, mas no .NET é SByte. Nesse caso, depende da importação de System
            // Os numéricos inteiros mais utilizados são o int / System.Int32 e o long / System.Int64
            // Os numéricos decimais mais utilizados são o float / System.Single e o double / System.Double
            // Quando se exigir um decimal com número MUITO grande, utiliza-se o decimal / System.Decimal
            // Também são muito importantes os bool / System.Boolean

            Console.WriteLine(x);
            */

            // Overflow -> Cálcula extrapola o limite da variável
            byte n1 = 255;
            n1++; // nesse caso, o valor da variável "reseta", iniciando pelo menor valor possível. Como no byte é 0
            // o valor será definido como 0. Se o menor valor fosse -128, ficaria -128
            Console.WriteLine("\nValor de n1: " + n1 + "\n");

            int n2 = 1000;
            int n3 = 2147483647; // maior valor de int
            long n4 = 2147483648L;

            System.Console.WriteLine(n2);
            System.Console.WriteLine(n3);
            System.Console.WriteLine(n4);

            bool ok = true;
            if (ok) System.Console.WriteLine(n1 + n2 + n3);

            char gender = 'F';
            System.Console.WriteLine(gender);

            float n5 = 4.5F;
            double n6 = 4.5D;

            string nome = "Mariana";

            System.Console.WriteLine(n5);
            System.Console.WriteLine(n6);
            System.Console.WriteLine(nome);


            /* Genéricos */
            Object fulano = "Rafael";
            var ciclano = "Jurandir";

            System.Console.WriteLine(fulano);
            System.Console.WriteLine(ciclano);

            /* Valores mínimos e máximos */

            // Tipo.MinValue -> retorna o menor valor do tipo
            // Tipo.MaxValue -> retorna o maior valor do tipo

            int int1 = int.MinValue;
            int int2 = int.MaxValue;
            sbyte sbyte1 = sbyte.MinValue;
            decimal decimal1 = decimal.MaxValue;

            System.Console.WriteLine(
                "int1: " + int1 +
                "\nint2: " + int2 +
                "\nsbyte1: " + sbyte1 +
                "\ndecimal1: " + decimal1
            );
        }
    }
}
